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
using Recipe_Management_System_Ahmed_Al_Doori_.Classes;
using Recipe_Management_System_Ahmed_Al_Doori_.Interfaces;

namespace Recipe_Management_System_Ahmed_Al_Doori_
{
    public partial class UserRegistrationForm : Form
    {
        #region SQL connection
        SqlConnection SqlConnection = new SqlConnection("");
        #endregion


        #region Form Constructor
        public UserRegistrationForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        #endregion


        #region Register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //checking if user enters his username and firstname and password
            if (txtFirstName.Text == String.Empty || txtPassword.Text == String.Empty || txtUserName.Text == String.Empty)
            {
                MessageBox.Show("User name and first name with password are required to register", "Required Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //let the user register if username and first name and password are written
            else
            {
                SqlConnection.Open();

                #region Check if user exisit in database

                string command = $"Select UserName From [User] Where UserName = '{txtUserName.Text}'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("This User name is used try to use another unique user name!", "Used User name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SqlConnection.Close();
                }

                #endregion

                #region If user not exist register the new user

                else
                {
                    NormalUser normalUser = new NormalUser();
                    normalUser.UserName = txtUserName.Text;
                    normalUser.FirstName = txtFirstName.Text;
                    if (txtLastName.Text != string.Empty)
                    {
                        normalUser.LastName = txtLastName.Text;
                    }
                    else
                    {
                        normalUser.LastName = " ";
                    }
                    normalUser.Password = txtPassword.Text;

                    #region Insert the User to data base


                    string InsertCommand = $"INSERT INTO [User] (UserName,FirstName,LastName,[Password]) VALUES('{normalUser.UserName}','{normalUser.FirstName}','{normalUser.LastName}','{normalUser.Password}')";
                    SqlCommand sqlCommand = new SqlCommand(InsertCommand, SqlConnection);
                    SqlDataAdapter InsertAdapter = new SqlDataAdapter();
                    InsertAdapter.InsertCommand = sqlCommand;
                    InsertAdapter.InsertCommand.ExecuteNonQuery();

                    #endregion

                    #region Congrats User if he is registerd successfuly and move him to log in page

                    

                    DialogResult result;
                    result = MessageBox.Show($"Congrats Dear {normalUser.FirstName}! You are now a registered user, you can login now!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }




                    #endregion

                    #endregion

                    SqlConnection.Close();
                    InsertAdapter.Dispose();
                    adapter.Dispose();

                }

            }
        }
        #endregion

    }
}
