using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebApp
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        SqlDataReader dataReader;

        public WebService()
        {
            //InitializeComponent();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        } 
        [WebMethod]
        public string GetConnection(string sFrom)
        {
            //connection path
            SqlConnection connString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=L:\Greenwich Part 3 Computer Science\Term 2\Programming Distributed Components\Coursework\Coursework\Database.mdf;Integrated Security=True;");

            //CHECK IT OUT -- https://www.geeksforgeeks.org/find-the-minimum-cost-to-reach-a-destination-where-every-station-is-connected-in-one-direction/

            string total = "";
            // reading from distance table for from station checking in both station1 and station2 columns 
            string myQuery = "Select * From Distance Where Station1 Like @station1";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@station1", "%" + sFrom + "%");

            //reading the data 
            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
                dataReader = myCommand.ExecuteReader();

                //if there is 1 matching then dont add 
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        total = dataReader.GetString(1) + " " + dataReader.GetString(3);
                    }
                    connString.Close();
                }
                else
                {
                    total = "No stations found";
                    connString.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            return total;
        }

    }
}
