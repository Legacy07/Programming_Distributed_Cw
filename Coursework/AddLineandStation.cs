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
    public partial class AddLineandStation : Form
    {
        int lineId = 0;
        int stationId = 0;

        SqlDataAdapter lineDataAdapter;
        SqlDataAdapter stationDataAdapter;

        public AddLineandStation()
        {
            InitializeComponent();
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
            string trainLine = lineTextbox.Text;

            DisplayData();
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
            //select all data from line table
            string getLinecommand = "Select * From Line";
            lineDataAdapter = new SqlDataAdapter(getLinecommand, connString);
            //select all data from line table
            string getStationcommand = "Select * From Station";
            stationDataAdapter = new SqlDataAdapter(getStationcommand, connString);
            //fill the table
            this.stationDataAdapter.Fill(
                this.stationDataSet.Station);
            this.lineDataAdapter.Fill(
                this.lineDataset.Line);
        }

        private void ClearData()
        {
            lineId = 0;
            stationId = 0;
            stationTextbox.Text = "";
            lineTextbox.Text = "";
            updateLineTextBox.Text = "";
            updateStationTextBox.Text = "";
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            string trainLine = lineTextbox.Text;
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
            // select every row in line table for name column which is the input of train line textbox 
            string myQuery = "Select * From Line Where Name = '" + trainLine + "'";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.ExecuteNonQuery();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            //if the train line exists in the database then output a message
            if (dataReader.HasRows)
            {
                outputLabel.Text = "Train line already exists";

            }

            else
            {
                try
                {
                    //if not then add the data in child table
                    DbHandler.AddLine(trainLine);
                    outputLabel.Text = "Train line added Successfully!";
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Successfully data added!");
                }
                catch (Exception ex)
                {
                    outputLabel.Text = "Error!" + ex;
                }
            }
        }

        private void addStationButton_Click(object sender, EventArgs e)
        {
            string trainStation = stationTextbox.Text;
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
            // select every row in line table for name column which is the input of train line textbox 
            string myQuery = "Select * From Station Where Name = '" + trainStation + "'";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.ExecuteNonQuery();
            SqlDataReader dataReader = myCommand.ExecuteReader();
            //if the train station exists in the database then output a message
            if (dataReader.HasRows)
            {
                outputLabel.Text = "Train line already exists";

            }

            else
            {
                try
                {
                    //if not then add the data in child table
                    DbHandler.AddStation(trainStation);
                    outputLabelStation.Text = "Train station added Successfully!";
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Successfully data added!");

                }
                catch (Exception ex)
                {
                    outputLabel.Text = "Error!" + ex;
                }
            }
        }

        private void AddLineandStation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lineDataset.Line' table. You can move, or remove it, as needed.
            this.lineDataAdapter.Fill(this.lineDataset.Line);
            // TODO: This line of code loads data into the 'databaseDataSet.Station' table. You can move, or remove it, as needed.
            this.stationDataAdapter.Fill(this.stationDataSet.Station);

        }
        //check it out for adding and updating 
        // https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control
        //updating train lines when edited and clicked on the update button
        private void updateLineButton_Click(object sender, EventArgs e)
        {
            if (updateLineTextBox.Text == "")
            {
                MessageBox.Show("Select a record");
            }
            else
            {
                //try updating line with corresponding id and refresh data
                try
                {
                    String line = updateLineTextBox.Text;
                    DbHandler.UpdateLine(lineId, line);
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Successfully data updated!");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
        }
        //update station
        private void updateStationbutton_Click(object sender, EventArgs e)
        {
            if (updateStationTextBox.Text == "")
            {
                MessageBox.Show("Select a record");
            }
            else
            {
                //try updating station with corresponding id and refresh data
                try
                {
                    String station = updateStationTextBox.Text;
                    DbHandler.UpdateStation(stationId, station);
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Successfully data updated!");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
        }

        private void lineDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   //get the id and the line and copy it to the text box so it can be updated 
            lineId = Convert.ToInt32(lineDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateLineTextBox.Text = lineDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void stationGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the id and the station and copy it to the text box so it can be updated 
            stationId = Convert.ToInt32(stationGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateStationTextBox.Text = stationGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void deleteLineButton_Click(object sender, EventArgs e)
        {
            if (updateLineTextBox.Text == "")
            {
                MessageBox.Show("Select a record");
            }
            else
            {
                String line = updateLineTextBox.Text;
                DialogResult dialog = MessageBox.Show("Do you want to delete Train Line = " + line, "Confirmation",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    //try deleting the row of selected id and associates then refresh data
                    try
                    {
                        DbHandler.DeleteLine(lineId);
                        DisplayData();
                        ClearData();
                        MessageBox.Show("Successfully data deleted!");

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                    }
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Nothing has been changed!");
                }
            }

        }

        private void deleteStationButton_Click(object sender, EventArgs e)
        {
            if (updateStationTextBox.Text == "")
            {
                MessageBox.Show("Select a record");
            }
            else
            {
                String station = updateStationTextBox.Text;
                //create dialog box to confirm deletion
                DialogResult dialog = MessageBox.Show("Do you want to delete Train Station = " + station, "Confirmation",
                    MessageBoxButtons.YesNoCancel);
                //if clicked yes then proceed deletion
                if (dialog == DialogResult.Yes)
                {
                    //try deleting the row of selected id and associates then refresh data
                    try
                    {
                        DbHandler.DeleteStation(stationId);
                        DisplayData();
                        ClearData();
                        MessageBox.Show("Successfully data deleted!");

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                    }
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Nothing has been changed!");
                }
            }
        }
    }
}
