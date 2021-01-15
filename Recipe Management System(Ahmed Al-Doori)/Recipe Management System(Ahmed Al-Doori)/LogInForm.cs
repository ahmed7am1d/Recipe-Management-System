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
    public partial class LogIn : Form
    {
        #region SQL connection
        SqlConnection SqlConnection = new SqlConnection("");
        #endregion

        #region From Constructor
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        #endregion

        #region Sign up button

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserRegistrationForm f1 = new UserRegistrationForm();
            f1.Show();

        }

        #endregion

        #region button sign in 
        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty || cmbBoxUserType.Text == string.Empty)
            {
                MessageBox.Show("You have to Enter Your User Name And Password with which type of User you are !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if all fields filled
            else
            {

                if (cmbBoxUserType.Text == "Normal User")
                {
                    SqlConnection.Open();
                    string command = $"Select UserName From [User] Where UserName = '{txtUserName.Text}' AND [Password] = '{txtPassword.Text}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(command, SqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        UserForm userForm = new UserForm(txtUserName.Text);
                        userForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("User name or password is Wrong!", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlConnection.Close();
                    }

                    SqlConnection.Close();
                    adapter.Dispose();

                }


                else if (cmbBoxUserType.Text == "Admin")
                {
                    SqlConnection.Open();
                    string command = $"SELECT UserName FROM [Admin] Where UserName = '{txtUserName.Text}' AND [Password] = '{txtPassword.Text}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(command, SqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        AdminForm adminform = new AdminForm();
                        adminform.Show();
                    }
                    else
                    {
                        MessageBox.Show("User name or password is Wrong!!", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlConnection.Close();
                    }
                    SqlConnection.Close();
                    adapter.Dispose();
                }

            }
        }

        #endregion

        #region Idont need it 
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        #endregion



    }
}
