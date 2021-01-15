using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe_Management_System_Ahmed_Al_Doori_.Classes;
using Recipe_Management_System_Ahmed_Al_Doori_.Interfaces;
using System.Data.SqlClient;

namespace Recipe_Management_System_Ahmed_Al_Doori_
{
    public partial class AdminForm : Form
    {
        #region SQl connection
        SqlConnection SqlConnection = new SqlConnection("");
        #endregion

        #region method to update with sepeicif status

        public void UpdateRecipe(string status)
        {
            SqlConnection.Open();
            string command = $"UPDATE Recipe SET RecipeStatus = '{status}' WHERE Recipe.RecipeID = {txtRecipeID.Text}; ";
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
            SqlDataAdapter sql = new SqlDataAdapter();
            sql.UpdateCommand = sqlCommand;
            sql.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("The Recipe has been Update", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection.Close();
            GetUsersRecipes();
        }


        #endregion

        #region Method to show pended users recipes to dgv
        public void GetUsersRecipes()
        {
            SqlConnection.Open();
            string SelectCommad = $"Select [User].UserID,[User].UserName,Recipe.RecipeID,Recipe.[Name],Recipe.RecipeStatus from [User] " +
                $"INNER JOIN Recipe on [User].UserID = Recipe.[User_ID];";
            SqlCommand sqlCommand = new SqlCommand(SelectCommad, SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dgvPendedRecipes.DataSource = dataTable;
            sqlCommand.Dispose();
            sqlDataReader.Close();
            dataTable.Dispose();
            SqlConnection.Close();
        }
        #endregion

        #region Method to show Selected user recipe ingredient
        public void GetUserRecipeIngredient()
        {
            SqlConnection.Open();
            string command = $"SELECT [User].UserName as UsersRecipe,Recipe.[Name] AS RecipeName, Ingredient.[Name] as IngredientName, Ingredient.Quantity as IngredientQuantity from Recipe " +
                $"INNER JOIN [User] ON Recipe.[User_ID] = [User].UserID " +
                $"INNER JOIN Ingredient on Recipe.RecipeID = Ingredient.Recipe_ID Where [User].UserID = {txtUserID.Text}; ";
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dgvUserRecipeIngredient.DataSource = dataTable;
            SqlConnection.Close();
            sqlCommand.Dispose();
            sqlDataReader.Close();
        }

        #endregion

        #region Method to show selected user recipe step 
        public void GetUserRecipeSteps()
        {
            SqlConnection.Open();
            string command = $"SELECT Recipe.[Name] as RecipeName, Step.[Description] As RecipesSteps FROM Recipe " +
                $"INNER JOIN Step on Recipe.RecipeID = Step.Recipe_ID " +
                $"INNER JOIN[User] on Recipe.[User_ID] = [User].UserID Where[User].UserID = {txtUserID.Text}; ";
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dgvRecipeUserStep.DataSource = dataTable;
            SqlConnection.Close();
            sqlCommand.Dispose();
            sqlDataReader.Close();
        }

        #endregion

        #region Form Constructor
        public AdminForm()
        {
            InitializeComponent();
            GetUsersRecipes();
        }
        #endregion

        #region Retrive data from data grid view using Cell Click Event
        private void dgvPendedRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvPendedRecipes.SelectedRows.Count > 0)
            {
                SqlConnection.Open();
                //allow to select only one row 
                DataGridViewRow dataGridView = dgvPendedRecipes.SelectedRows[0];

                txtUserID.Text = dataGridView.Cells[0].Value.ToString();
                txtUserName.Text = dataGridView.Cells[1].Value.ToString();
                txtRecipeID.Text = dataGridView.Cells[2].Value.ToString();
                txtUserRecipeName.Text = dataGridView.Cells[3].Value.ToString();
                txtRecipeStatus.Text = dataGridView.Cells[4].Value.ToString();
                SqlConnection.Close();
                

            }

            
        }



        #endregion

        #region Button Show Ingredient

        
        private void btnShowIngredientandStep_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text == string.Empty)
            {
                MessageBox.Show("You have to select a recipe First","Missing Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                GetUserRecipeIngredient();
                GetUserRecipeSteps();
            }
        }


        #endregion

        #region Update Recipe
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (txtRecipeID.Text == string.Empty)
            {
                MessageBox.Show("Select the User's recipe first !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult result;
                result = MessageBox.Show("Are you sure you want to Update the recipe Status ?", "Confrmition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    if(txtRecipeStatus.Text == "Approved")
                    {
                        UpdateRecipe("Approved");
                    }
                    
                    else if (txtRecipeStatus.Text =="Unaapproved")
                    {
                        UpdateRecipe("Unaapproved");

                    }
                    else if (txtRecipeStatus.Text == "Pended")
                    {
                        UpdateRecipe("Pended");
                    }
                   
                    else
                    {
                        MessageBox.Show("You have to enter either Pended or Unapproved or Approved", "Case Senstive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Recipe is not updated", "Confrmition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        #endregion

        #region Un nessacary
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Delete Recipe

        
        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text == string.Empty || txtRecipeID.Text == string.Empty)
            {
                MessageBox.Show("Select the User's recipe first !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult result;
                result = MessageBox.Show("Are you sure you want to delete the recipe forever ?", "Confrmition", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {


                    #region Delete Recipe's ingredient and step
                    //Ingrediant

                    SqlConnection.Open();
                    string command2 = $"DELETE FROM Ingredient Where Recipe_ID = {txtRecipeID.Text}";
                    SqlCommand sql = new SqlCommand(command2, SqlConnection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                    sqlDataAdapter1.DeleteCommand = sql;
                    sqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    sqlDataAdapter1.Dispose();

                    //steps 
                    SqlConnection.Open();
                    string command3 = $"Delete from Step Where Recipe_ID = {txtRecipeID.Text}";
                    SqlCommand sql2 = new SqlCommand(command3, SqlConnection);
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
                    sqlDataAdapter2.DeleteCommand = sql2;
                    sqlDataAdapter2.DeleteCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    sqlDataAdapter2.Dispose();

                    


                    #region DeleteRecipe it self 
                    SqlConnection.Open();
                    string Command = $"DELETE FROM Recipe Where RecipeID = {txtRecipeID.Text} ;";
                    SqlCommand sqlCommand = new SqlCommand(Command, SqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.DeleteCommand = sqlCommand;
                    sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                    sqlDataAdapter.Dispose();
                    GetUserRecipeIngredient();
                    GetUserRecipeSteps();
                    GetUsersRecipes();
                    #endregion

                    #endregion
                }
                else
                {
                    MessageBox.Show("Recipe is not Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
    }
}
