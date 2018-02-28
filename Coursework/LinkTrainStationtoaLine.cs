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
    public partial class LinkTrainStationtoaLine : Form
    {

        SqlDataAdapter lineDataAdapter;
        SqlDataAdapter stationDataAdapter;
        SqlDataAdapter linkedStationAdapter;
        //connection
        SqlConnection connString = DbHandler.GetConnection();
        int stationId = 0;

        string station = "";
        string line = "";
        string selectedLine;

        public LinkTrainStationtoaLine()
        {
            InitializeComponent();

            DisplayData();
        }

        private void LinkTrainStationtoaLine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.StationsLineLink' table. You can move, or remove it, as needed.
            this.linkedStationAdapter.Fill(this.stationsLineLinkDataset.StationsLineLink);
            // TODO: This line of code loads data into the 'lineDataset.Line' table. You can move, or remove it, as needed.
            this.lineDataAdapter.Fill(this.lineDataSet.Line);
            // TODO: This line of code loads data into the 'stationDataSet.Station' table. You can move, or remove it, as needed.
            this.stationDataAdapter.Fill(this.stationDataSet.Station);

        }
        private void DisplayData()
        {

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
            //select all data from Stations line lik table 
            string getlinkedStation = "Select * From StationsLineLink";
            linkedStationAdapter = new SqlDataAdapter(getlinkedStation, connString);
            //fill the table
            this.stationDataAdapter.Fill(
                this.stationDataSet.Station);
            this.lineDataAdapter.Fill(
                this.lineDataSet.Line);
            this.linkedStationAdapter.Fill(
               this.stationsLineLinkDataset.StationsLineLink);
        }
        private void linkButton_Click(object sender, EventArgs e)
        {
            station = stationCombox.SelectedValue.ToString();
            line = lineComboBox.SelectedValue.ToString();
            try
            {
                //open connection
                connString.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            DialogResult dialog = MessageBox.Show("Do you want to link train station: " + station + " to train line: " + line + "?", "Confirmation",
                    MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                //reading from StationsLineLink table to check if the train station is already linked with the train line
                string myQuery = "Select * From StationsLineLink Where Station = @station AND Line = @line";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.Parameters.AddWithValue("@station", station);
                myCommand.Parameters.AddWithValue("@line", line);

                //executing the command
                var sStationCheck = myCommand.ExecuteScalar();

                //if station matches with the selected train station thats already linked then output error
                if (sStationCheck != null)
                {
                    MessageBox.Show("This train station: " + station + " is already linked to the train line: " + line);
                }
                else
                {
                    //add the data
                    DbHandler.AddLinkedStations(station, line);
                    MessageBox.Show(station + " is been linked to the " + line);
                    RefreshDataGridView();

                }

            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Nothing has been added!");
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the id from selected row
            stationId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            removeTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            selectedLine = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (removeTextbox.Text == "")
            {
                MessageBox.Show("Select a record");
            }
            else
            {
                String station = removeTextbox.Text;
                DialogResult dialog = MessageBox.Show("Do you want to remove the linkage of Train Station: " + station +
                    " from the Train Line: " + selectedLine, "Confirmation",
                    MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    //try deleting the row of selected id and associates then refresh data
                    try
                    {
                        DbHandler.DeleteStationLink(stationId);
                        RefreshDataGridView();
                        MessageBox.Show("Successfully data deleted!");
                        connString.Close();

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                    }
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Nothing has been changed!");
                    connString.Close();
                }
            }

        }

        private void RefreshDataGridView()
        {
            string selectedStation1 = stationCombox.SelectedValue.ToString();
            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            //create datatable to refresh and fill data
            DataTable linkedStationdt = new DataTable();
            linkedStationAdapter = new SqlDataAdapter("Select * From StationsLineLink", connString);
            linkedStationAdapter.Fill(linkedStationdt);
            dataGridView.DataSource = linkedStationdt;
            connString.Close();
        }
    }
}
