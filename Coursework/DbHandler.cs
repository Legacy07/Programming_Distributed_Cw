using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;

namespace Coursework
{
    public class DbHandler
    {

        public static SqlConnection GetConnection()
        {
            //connection path
            string connString;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=L:\Greenwich Part 3 Computer Science\Term 2\Programming Distributed Components\Coursework\Coursework\Database.mdf;Integrated Security=True;";
            return new SqlConnection(connString);
        }

        public static void AddAdmin(string username, string password)
        {
            SqlConnection connString = GetConnection();
            //to add data in admin table in the database
            string myQuery = "INSERT INTO Admin(Username, Password) VALUES (@username, @password)";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@username", username);
            myCommand.Parameters.AddWithValue("@password", password);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }
        public static void AddLine(string line)
        {
            SqlConnection connString = GetConnection();
            //to add data in Line table in the database
            string myQuery = "INSERT INTO Line( Name) VALUES (@line)";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@line", line);
            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }
        public static void AddStation(string station)
        {
            SqlConnection connString = GetConnection();
            //to add data in station table in the database
            string myQuery = "INSERT INTO Station( Name) VALUES (@station)";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@station", station);
            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }
        public static void AddDistance(string station1, string station2, string line1, string line2, string distance)
        {
            SqlConnection connString = GetConnection();
            //to add data in station table in the database
            string myQuery = "INSERT INTO Distance( Station1, Station2, Line1, Line2, Distance) " +
                "VALUES (@station1, @station2, @line1, @line2, @distance)";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@station1", station1);
            myCommand.Parameters.AddWithValue("@station2", station2);
            myCommand.Parameters.AddWithValue("@line1", line1);
            myCommand.Parameters.AddWithValue("@line2", line2);
            myCommand.Parameters.AddWithValue("@distance", distance);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

        public static void DeleteDistance(int id)
        {
            SqlConnection connString = GetConnection();
            //delete id in station table 
            string myQuery = "Delete Distance where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

        public static void UpdateStation(int id, string name)
        {
            SqlConnection connString = GetConnection();
            //update station data
            string myQuery = "Update Station set Name=@name where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);
            myCommand.Parameters.AddWithValue("@name", name);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

        public static void UpdateLine(int id, string name)
        {
            SqlConnection connString = GetConnection();
            //update station data
            string myQuery = "Update Line set Name=@name where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);
            myCommand.Parameters.AddWithValue("@name", name);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

        public static void DeleteLine(int id)
        {
            SqlConnection connString = GetConnection();
            //delete the row where id is selected
            string myQuery = "Delete Line where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }
        public static void DeleteStation(int id)
        {
            SqlConnection connString = GetConnection();
            //delete id in station table 
            string myQuery = "Delete Station where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

        public static void AddLinkedStations(string station, string line)
        {
            SqlConnection connString = GetConnection();
            //to add data in station to a line table in the database
            string myQuery = "INSERT INTO StationsLineLink( Station, Line) VALUES (@station, @line)";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@station", station);
            myCommand.Parameters.AddWithValue("@line", line);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }
        public static void DeleteStationLink(int id)
        {
            SqlConnection connString = GetConnection();
            //delete id in station table 
            string myQuery = "Delete StationsLineLink where ID=@id";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //using parameters to avoid sql injection
            myCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }


    }
}
