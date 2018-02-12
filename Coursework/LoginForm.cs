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
        public LoginForm()
        {
            InitializeComponent();
            usernameTextbox.Text = "Ahmet";
            passwordTextbox.Text = "1234";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {   
            //get username out of the textbox
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
          
            SqlConnection connString = DbHandler.GetConnection();

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
            string myQuery = "Select Password From Admin Where Username = '" + username + "'";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);
            //executing the command
            string password1 = myCommand.ExecuteScalar().ToString().Replace(" ", "");

            //if password matches with the textbox and the username then open 
            if (password1 == passwordTextbox.Text)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Text = "Try Again!";

                //close connection
                connString.Close();
            }
        }
    }
}
