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
    public partial class ShortestRoute : Form
    {
        //connection
        SqlConnection connString = DbHandler.GetConnection();

        SqlDataReader dataReader;

        public ShortestRoute()
        {
            InitializeComponent();
        }

        //CHECK THESE OUT FOR SOAP WEB SERVICE
        //https://www.codeproject.com/Articles/94043/SOAP-Web-Services-Create-Once-Consume-Everywhere
        //https://www.youtube.com/watch?v=uBwHedD5xx0
        //https://support.microsoft.com/en-gb/help/308359/how-to-write-a-simple-web-service-by-using-visual-c-net
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                connString.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            string sFrom = fromTextBox.Text;
            string sTo = toTextBox.Text;

            if (sFrom == "" || sTo == "")
            {
                MessageBox.Show("Fields cannot be empty!");
            }
            else
            {
                //CHECK IT OUT -- https://www.geeksforgeeks.org/find-the-minimum-cost-to-reach-a-destination-where-every-station-is-connected-in-one-direction/

                // reading from distance table for from station checking in both station1 and station2 columns 
                string myQuery = "Select * From Distance Where Station1 Like @station1";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.Parameters.AddWithValue("@station1", "%" + sFrom + "%");

                //reading the data 
                //int rows = (int)myCommand.ExecuteScalar();
                myCommand.ExecuteNonQuery();
                dataReader = myCommand.ExecuteReader();
                //if there is 1 matching then dont add 
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        resultLabel.Text = dataReader.GetString(1) + dataReader.GetString(3);
                    }
                    connString.Close();
                }
                else
                {
                    resultLabel.Text = "No stations found";
                    connString.Close();
                }

            }
        }
    }
}
