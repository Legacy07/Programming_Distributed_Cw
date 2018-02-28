using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class _Default : Page
    {
        localhostWebServiceReference.WebService webService = new localhostWebServiceReference.WebService();
        //connection
        //SqlConnection connString = new SqlConnection();

        //SqlDataReader dataReader;
        
           
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void calculateButton_Click(object sender, EventArgs e)
        {
            string sFrom = fromTextBox.Value.ToString();
            string sTo = toTextBox.Value.ToString();

            resultLabel.Text = webService.GetConnection(sFrom);
            
           
            /*  //CHECK THESE OUT FOR SOAP WEB SERVICE
              //https://www.codeproject.com/Articles/94043/SOAP-Web-Services-Create-Once-Consume-Everywhere
              //https://www.youtube.com/watch?v=uBwHedD5xx0
              //https://support.microsoft.com/en-gb/help/308359/how-to-write-a-simple-web-service-by-using-visual-c-net


              string sFrom = fromTextBox.Value.ToString();
              string sTo = toTextBox.Value.ToString();

              if (sFrom == "" || sTo == "")
              {
                  resultLabel.Text = "Fields cannot be empty!";
              }
              else
              {
                  //CHECK IT OUT -- https://www.geeksforgeeks.org/find-the-minimum-cost-to-reach-a-destination-where-every-station-is-connected-in-one-direction/

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
                  catch (Exception ex)
                  {
                      Console.WriteLine("Exception in DBHandler", ex);
                  }



              }
          }*/
        }
    }
}
