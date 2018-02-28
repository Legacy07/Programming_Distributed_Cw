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
    public partial class LoginForm : Form
    {
        string username = "";
        string password = "";
        SqlConnection connString = DbHandler.GetConnection();

        public LoginForm()
        {
            InitializeComponent();
            usernameTextbox.Text = "Ahmet";
            passwordTextbox.Text = "1234";
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //get username out of the textbox
            username = usernameTextbox.Text;
            password = passwordTextbox.Text;

            try
            {
                //open connection
                connString.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            //reading from admin table which username is from the input of username textbox, which password is also associated.
            string myQuery = "Select Count(*) From Admin Where Username = @username AND Password = @password";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            myCommand.Parameters.AddWithValue("@username", username);
            myCommand.Parameters.AddWithValue("@password", password);

            //reading the data 
            int rows = (int)myCommand.ExecuteScalar();

            //if there is 1 matching then continue 
            if (rows > 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Try Again!");

                //close connection
                connString.Close();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //get username and password out of the textbox
            username = usernameTextbox.Text;
            password = passwordTextbox.Text;

            try
            {
                //open connection
                connString.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            //if any of the fields are empty output an error
            if (username == "" || password == "")
            {
                MessageBox.Show("The fields cannot be empty");
            }
            else
            {
                //reading from admin table which username is from the input of username textbox.
                string myQuery = "Select Count(Username) From Admin Where Username = @username";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.Parameters.AddWithValue("@username", username);
                //reading data 
                int rows = (int)myCommand.ExecuteScalar();
                //if there is any found username then output error
                if (rows > 0)
                {
                    MessageBox.Show("Duplicate username, Please choose a different username");
                }
                else
                {

                    DialogResult dialog = MessageBox.Show("Are you sure you want to create an account with the username: "
        + username, "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DbHandler.AddAdmin(username, password);
                            MessageBox.Show("Successfully a new admin account created!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Occured!" + ex);
                        }
                        finally
                        {
                            connString.Close();
                        }
                    }
                    else if (dialog == DialogResult.No)
                    {
                        MessageBox.Show("Choose a better username");

                    }
                }
            }
        }
    }
}
