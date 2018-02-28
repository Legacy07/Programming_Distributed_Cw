using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework
{
    public partial class AddDistance : Form
    {
        SqlDataAdapter station1DataAdapter;
        SqlDataAdapter station2DataAdapter;
        SqlDataAdapter distanceDataAdapter;
        SqlDataAdapter refreshDistanceDataAdapter;

        //connection
        SqlConnection connString = DbHandler.GetConnection();

        string selectedStation = "";
        string selectedStation2 = "";
        string selectedLine1 = "";
        string selectedLine2 = "";

        int id = 0;
        int errorOccured = 0;

        public AddDistance()
        {
            InitializeComponent();


            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            DisplayData();
            ListLinkedLines();
            //add keypress handler
            this.addDistanceTextbox.KeyPress += new KeyPressEventHandler(addDistanceTextbox_KeyPress);

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            selectedLine1 = line1Combobox.SelectedValue.ToString();
            selectedLine2 = line2Combobox.SelectedValue.ToString();
            selectedStation = station1Combobox.SelectedValue.ToString();
            selectedStation2 = station2Combobox.SelectedValue.ToString();

            string sCheckDistanceTextBox = addDistanceTextbox.Text.ToString();
            int intDistanceTextBox;
            var intCheckDistanceTextBox = Int32.TryParse(addDistanceTextbox.Text, out intDistanceTextBox);

            // reading from distance table checking for already added distance between two stations with same train lines
            string myQuery = "Select Count(*) From Distance Where Station1 = @station1 " +
                "AND Station2 = @station2 AND Line1 = @line1 AND Line2 = @line2 ";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@station1", selectedStation);
            myCommand.Parameters.AddWithValue("@station2", selectedStation2);
            myCommand.Parameters.AddWithValue("@line1", selectedLine1);
            myCommand.Parameters.AddWithValue("@line2", selectedLine2);

            //reading the data 
            int rows = (int)myCommand.ExecuteScalar();

            //if there is 1 matching then dont add 
            if (rows > 0)
            {
                MessageBox.Show("Station 1: " + selectedStation + " for line: " + selectedLine1 +
                           " and Station 2: " + selectedStation2 + " for line 2: " + selectedLine2
                           + " are already been added!");
                errorOccured = 1;
                connString.Close();

            }
            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            // reading from distance table checking for already added distance between two stations but selected in opposite comboboxes 
            //so there is no duplicates in either stations with same train lines
            string myQuery2 = "Select Count(*) From Distance Where Station1 = @sStation2 " +
                "AND Station2 = @sStation1 AND Line1 = @sLine1 AND Line2 = @sLine2 ";
            SqlCommand myCommand2 = new SqlCommand(myQuery2, connString);
            myCommand2.Parameters.AddWithValue("@sStation2", selectedStation2);
            myCommand2.Parameters.AddWithValue("@sStation1", selectedStation);
            myCommand2.Parameters.AddWithValue("@sLine1", selectedLine1);
            myCommand2.Parameters.AddWithValue("@sLine2", selectedLine2);

            //reading the data 
            int rows2 = (int)myCommand2.ExecuteScalar();

            //if there is 1 matching then dont add 
            if (rows2 > 0)
            {
                MessageBox.Show("second error: Station 1: " + selectedStation + " for line: " + selectedLine1 +
                           " and Station 2: " + selectedStation2 + " for line 2: " + selectedLine2
                           + " are already been added!");
                connString.Close();

            }

            //distance textbox cannot be empty
            else if (sCheckDistanceTextBox == "")
            {
                MessageBox.Show("You need to enter some value");
            }
            //if the distance is lower than 0 then output error
            else if (intDistanceTextBox == 0 || intDistanceTextBox < 0)
            {
                MessageBox.Show("Distance should be more than '0'");

            }
            //if the lines aren't the same
            else if (!selectedLine1.Equals(selectedLine2))
            {
                MessageBox.Show("Not allowed to choose different lines!");
            }
            //if the stations are the same
            else if (selectedStation.Equals(selectedStation2))
            {
                MessageBox.Show("Not allowed to choose same stations!");
            }

            else
            {
                if (errorOccured == 1)
                {
                    errorOccured = 0;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to continue?", "Confirmation",
                   MessageBoxButtons.YesNoCancel);
                    if (dialog == DialogResult.Yes)
                    {
                        //add the data to the database 
                        DbHandler.AddDistance(selectedStation, selectedStation2, selectedLine1,
                          selectedLine2, sCheckDistanceTextBox);
                        RefreshDataGridView();
                        MessageBox.Show("Data successfully added!");

                    }
                    else if (dialog == DialogResult.No)
                    {
                        MessageBox.Show("Nothing's been changed");
                    }
                }

                //close connection
                connString.Close();

            }


        }
        //listing the linked lines only prior to selected station
        private void ListLinkedLines()
        {

            if (station1Combobox.SelectedItem == null || station2Combobox.SelectedItem == null)
            {

            }
            else
            {
                //get values from station comboboxes 
                selectedStation = station1Combobox.SelectedValue.ToString();
                selectedStation2 = station2Combobox.SelectedValue.ToString();

            }

            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            //listing linked lines for station 1
            try
            {
                //selecting all the values thats linked to the selected station in combobox
                string myQuery = "Select * From StationsLineLink Where Station = @station";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.Parameters.AddWithValue("@station", selectedStation);
                //create new data adapter to call the command and retrieve the rows instead of using data reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand);
                //new dataset to bind data from data adapter 
                DataSet dataset = new DataSet();
                //listing the data in combobox by id from Line column
                dataAdapter.Fill(dataset, "StationsLineLink");
                line1Combobox.DisplayMember = "Line";
                line1Combobox.ValueMember = "Line";
                line1Combobox.DataSource = dataset.Tables["StationsLineLink"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }

            //listing linked lines for station 2
            try
            {
                //selecting all the values thats linked to the selected station in combobox
                string myQuery = "Select * From StationsLineLink Where Station = @station";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.Parameters.AddWithValue("@station", selectedStation2);
                //create new data adapter to call the command and retrieve the rows instead of using data reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand);
                //new dataset to bind data from data adapter 
                DataSet dataset = new DataSet();
                //listing the data in combobox by id from Line column
                dataAdapter.Fill(dataset, "StationsLineLink");
                line2Combobox.DisplayMember = "Line";
                line2Combobox.ValueMember = "Line";
                line2Combobox.DataSource = dataset.Tables["StationsLineLink"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }

        private void DisplayData()
        {
            //connection
            SqlConnection connString = DbHandler.GetConnection();

            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            //select all data from station table
            string getStationcommand = "Select * From Station";
            station1DataAdapter = new SqlDataAdapter(getStationcommand, connString);
            //select all data from station table
            string getStation2command = "Select * From Station";
            station2DataAdapter = new SqlDataAdapter(getStation2command, connString);
            //select all data from distance table
            string getDistancecommand = "Select * From Distance";
            distanceDataAdapter = new SqlDataAdapter(getDistancecommand, connString);
            //fill the station table
            this.station1DataAdapter.Fill(
                this.stationDataset.Station);
            this.station2DataAdapter.Fill(
               this.station2Dataset.Station);
            this.distanceDataAdapter.Fill(
                this.distanceDataset.Distance);
        }

        private void AddDistance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'line2Dataset.Line' table. You can move, or remove it, as needed.
            // this.line1DataAdapter.Fill(this.lineDataset.Line);
            // TODO: This line of code loads data into the 'station2Dataset.Station' table. You can move, or remove it, as needed.
            // this.station1DataAdapter.Fill(this.stationDataset.Station);
            // TODO: This line of code loads data into the 'distanceDataset.Distance' table. You can move, or remove it, as needed.
            // this.distanceDataAdapter.Fill(this.distanceDataset.Distance);
            // TODO: This line of code loads data into the 'lineDataset.Line' table. You can move, or remove it, as needed.
            //  this.line2DataAdapter.Fill(this.line2Dataset.Line);
            // TODO: This line of code loads data into the 'databaseDataSet7.Station' table. You can move, or remove it, as needed.
            // this.station2DataAdapter.Fill(this.station2Dataset.Station);

        }

        private void addDistanceTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {   //users only allowed to enter numbers and ability to press backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void station1Combobox_TextChanged(object sender, EventArgs e)
        {
            ListLinkedLines();
        }

        private void station2Combobox_TextChanged(object sender, EventArgs e)
        {
            ListLinkedLines();

        }
        //add 5 everytime is clicked 
        private void plusButton_Click(object sender, EventArgs e)
        {
            int add = 0;
            var intCheckDistanceTextBox = Int32.TryParse(addDistanceTextbox.Text, out add);

            add += 5;
            //change the text color when it hits 50 or above
            if (add >= 50)
            {
                addDistanceTextbox.BackColor = Color.FromKnownColor(KnownColor.Control);
                addDistanceTextbox.ForeColor = Color.Red;
            }
            addDistanceTextbox.Text = add.ToString();

        }
        //subtract everytime is clicked
        private void minusbutton_Click(object sender, EventArgs e)
        {
            int subtract = 0;
            var intCheckDistanceTextBox = Int32.TryParse(addDistanceTextbox.Text, out subtract);

            subtract -= 5;
            //change the text coor when it goes below 50
            if (subtract < 50)
            {
                addDistanceTextbox.BackColor = Color.FromKnownColor(KnownColor.Control);
                addDistanceTextbox.ForeColor = Color.Black;
            }
            //if it treis to go below 0, dont allow it 
            if (subtract < 0)
            {
                subtract = 0;
            }
            addDistanceTextbox.Text = subtract.ToString();
        }

        private void distanceDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(distanceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            idRemoveTextbox.Text = id.ToString();
        }

        private void RefreshDataGridView()
        {
            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            //create datatable to refresh and fill data
            DataTable distanceDatatable = new DataTable();
            refreshDistanceDataAdapter = new SqlDataAdapter("Select * From Distance", connString);
            refreshDistanceDataAdapter.Fill(distanceDatatable);
            distanceDataGridView.DataSource = distanceDatatable;
            connString.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string sRemoveTextbox = idRemoveTextbox.Text;
            if (sRemoveTextbox == "")
            {
                MessageBox.Show("Select a record!");

            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    DbHandler.DeleteDistance(id);
                    RefreshDataGridView();
                    MessageBox.Show("Successfully data deleted");
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Nothing's been changed");
                }
            }
        }
    }


}
