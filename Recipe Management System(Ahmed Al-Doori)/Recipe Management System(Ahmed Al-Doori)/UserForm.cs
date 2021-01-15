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
    public partial class UserForm : Form
    {
        #region Sql connection

        SqlConnection SqlConnection = new SqlConnection("");
        #endregion

        #region Method to show Recipes to the specific user 

        public void GetUserRecipes()
        {
            //close connection if there is and then open to handle any exceptions
            SqlConnection.Close();
            SqlConnection.Open();
            string selectCommand = $"Select [User].FirstName,Recipe.[Name] AS RecipeName,Recipe.[Description] as RecipeDescription, Category.[Name] AS RecipeCategory, Recipe.RecipeStatus From Recipe INNER JOIN Category ON Recipe.Category_ID = Category.CategoryID INNER JOIN[User] ON Recipe.[User_ID] = [User].UserID " +
                $"Where User_ID = {txtUserID.Text}; ";
            SqlCommand sql = new SqlCommand(selectCommand, SqlConnection);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dgvPendedRecipe.DataSource = dataTable;
            
            SqlConnection.Close();
            sqlDataReader.Close();

        }


        #endregion

        #region Method to show recipes ingrediant 

        public void GetRecipeIngredient()
        {
            SqlConnection.Close();
            SqlConnection.Open();
            string IngrediantstepCOMMAND = $"SELECT Recipe.[Name] as RecipeName, Ingredient.[Name] as IngredientName, Ingredient.Quantity from Recipe INNER JOIN Ingredient ON Recipe.RecipeID = Ingredient.Recipe_ID " +
                $"INNER JOIN [User] on Recipe.[User_ID] = [User].UserID where[User].UserName = '{txtUserName.Text}'; ";
            SqlCommand sqlCommand = new SqlCommand(IngrediantstepCOMMAND,SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dgvRecipeStepAndIngredient.DataSource = dataTable;
            SqlConnection.Close();
            sqlDataReader.Close();
            sqlCommand.Dispose();

        }



        #endregion

        #region Method to Show Recipes Steps
        public void GetRecipesStep()
        {
            SqlConnection.Close();
            SqlConnection.Open();
            string command = $"SELECT Recipe.[Name] as RecipeName,Step.[Description] as RecipeSteps from Recipe INNER JOIN Step on Recipe.RecipeID= Step.Recipe_ID INNER JOIN [User] on Recipe.[User_ID] = [User].UserID " +
                $"WHERE[UserName] = '{txtUserName.Text}'; ";
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable d1 = new DataTable();
            d1.Load(dataReader);
            dgvRecipesSteps.DataSource = d1;
            SqlConnection.Close();
            sqlCommand.Dispose();
            dataReader.Close();
        }


        #endregion

        #region Method to check category
        int categoryId = 0;
        public int GetCategoryID()
        {


            if (comboBoxCategory.Text == "BreakFast")
            {
                categoryId = 1;
            }
            else if (comboBoxCategory.Text == "Lunch")
            {
                categoryId = 2;
            }
            else if (comboBoxCategory.Text == "Dinner")
            {
                categoryId = 3;
            }
            else if (comboBoxCategory.Text == "Apptizer")
            {
                categoryId = 4;
            }
            else if (comboBoxCategory.Text == "Dessert")
            {
                categoryId = 5;
            }
            else if (comboBoxCategory.Text == "Beverage")
            {
                categoryId = 6;
            }
            else if (comboBoxCategory.Text == "Juice")
            {
                categoryId = 7;
            }



            return categoryId;
        }


        #endregion

        #region The Form Constructor
        public UserForm(string UserName)
        {
            InitializeComponent();
            txtUserName.Text = UserName;

            //get the user id
            SqlConnection.Open();
            string Command = $"SELECT UserID from [User] Where UserName = '{txtUserName.Text}'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command, SqlConnection);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            txtUserID.Text = dt.Rows[0][0].ToString();
            SqlConnection.Close();
            Adapter.Dispose();

            //showing approved recipes to all kind of users 

            SqlConnection.Open();
            string command2 = $"SELECT [User].FirstName +' '+[User].LastName as RecipeAuthor,Recipe.[Name], Recipe.[Description],Recipe.RecipeStatus from Recipe " +
                $"inner join[User] on[USER].UserID = Recipe.[User_ID] Where Recipe.RecipeStatus = 'Approved'";
            SqlCommand sqlCommand = new SqlCommand(command2, SqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dataReader);
            dgvApprovedRecipes.DataSource = dt1;
            SqlConnection.Close();
            dataReader.Close();

        }
        #endregion

        #region Submit recipe button
        private void btnSubmitRecipe_Click(object sender, EventArgs e)
        {

            #region if user Enter empty data to text boxes and submit 

            if (txtRecipeName.Text == string.Empty || txtRecipeDescription.Text == string.Empty || comboBoxCategory.Text == string.Empty)
            {
                MessageBox.Show("Enter recipe inforamtion before submitting", "inVaildInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            #region main else if user enters data to the textboxes and they are filled

            else
            {
                #region If the recipe ID is not exisits in the User interface let him enter new recipe

                if (txtRecipeID.Text == string.Empty)
                {



                    SqlConnection.Open();
                    Recipe recipe = new Recipe();
                    recipe.Name = txtRecipeName.Text;
                    recipe.Description = txtRecipeDescription.Text;
                    recipe.User_ID = int.Parse(txtUserID.Text);
                    recipe.Category = comboBoxCategory.Text;



                    string command01 = $"SELECT [Name] from Recipe Where [Name] = '{recipe.Name}'; ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(command01, SqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter1.Fill(dataTable);

                    //Check IF Recipe is already exist in database if yes user can not enter it (by recipe name)
                    if (dataTable.Rows.Count == 1)
                    {
                        MessageBox.Show("This Recipe is already exists try to enter another one !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlConnection.Close();
                    }
                    else
                    {

                        #region Check the category id to insert to data base

                        categoryId = GetCategoryID();


                        string command = $"INSERT INTO Recipe([Name],[Description],[User_ID],Category_ID)Values('{recipe.Name}','{recipe.Description}','{recipe.User_ID}',{categoryId});";
                        SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.InsertCommand = sqlCommand;
                        sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                        GetUserRecipes();
                        GetRecipeIngredient();
                        GetRecipesStep();
                        SqlConnection.Close();
                        sqlDataAdapter.Dispose();
                        #endregion


                        #region put the created recipe id in the text box of recipe id 

                        SqlConnection.Open();
                        string command02 = $"SELECT RecipeID from Recipe Where [Name] = '{txtRecipeName.Text}' AND User_ID = {txtUserID.Text};";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command02, SqlConnection);
                        DataTable dt2 = new DataTable();
                        dataAdapter.Fill(dt2);
                        txtRecipeID.Text = dt2.Rows[0][0].ToString();
                        SqlConnection.Close();
                        dataAdapter.Dispose();

                        #endregion


                    }

                }
                #endregion



                #region Else if the recipe id is exists in the User interface 
                else
                {
                    #region check if the current recipe has no steps and ingredient if yes don't let him create new one

                    
                    string joinCommand = $"SELECT Recipe.RecipeID from Recipe " +
                        $"INNER JOIN Ingredient ON Recipe.RecipeID = Ingredient.Recipe_ID " +
                        $"INNER JOIN Step ON Step.Recipe_ID = Recipe.RecipeID WHERE Recipe.RecipeID = '{txtRecipeID.Text}'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(joinCommand, SqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("You have to add Ingrediant and step to the recipe first !!! ", "MissingInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlConnection.Close();
                        sqlDataAdapter.Dispose();
                    }
                    #endregion

                    #region else if the current recipe has steps and ingredient and he want to create new we are going to check if recipe exists
                   
                    else
                    {



                        SqlConnection.Open();
                        Recipe recipe = new Recipe();
                        recipe.Name = txtRecipeName.Text;
                        recipe.Description = txtRecipeDescription.Text;
                        recipe.User_ID = int.Parse(txtUserID.Text);
                        recipe.Category = comboBoxCategory.Text;
                        int categoryId = 0; // to send the category id to database

                        #region iNSERT RECIPE

                        //CHECH IF Recipe is already exist user can not enter it (by recipe name)
                        string command01 = $"SELECT [Name] from Recipe Where [Name] = '{recipe.Name}'; ";
                        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(command01, SqlConnection);
                        DataTable dataTable1 = new DataTable();
                        sqlDataAdapter1.Fill(dataTable1);

                        if (dataTable1.Rows.Count == 1)
                        {
                            MessageBox.Show("This Recipe is already exists try to enter another one !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SqlConnection.Close();
                        }

                        else
                        {

                            #region Check the category id to insert to data base using getcategoryID method

                            categoryId = GetCategoryID();

                            string command = $"INSERT INTO Recipe([Name],[Description],[User_ID],Category_ID)Values('{recipe.Name}','{recipe.Description}','{recipe.User_ID}',{categoryId});";
                            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
                            SqlDataAdapter sqlDataAdapter11 = new SqlDataAdapter();
                            sqlDataAdapter11.InsertCommand = sqlCommand;
                            sqlDataAdapter11.InsertCommand.ExecuteNonQuery();
                            GetUserRecipes();
                            GetRecipeIngredient();
                            GetRecipesStep();
                            SqlConnection.Close();
                            sqlDataAdapter1.Dispose();

                            #endregion


                            #region put the created recipe id in the text box of recipe id 

                            SqlConnection.Open();
                            string command02 = $"SELECT RecipeID from Recipe Where [Name] = '{txtRecipeName.Text}' AND User_ID = {txtUserID.Text};";
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command02, SqlConnection);
                            DataTable dt2 = new DataTable();
                            dataAdapter.Fill(dt2);
                            txtRecipeID.Text = dt2.Rows[0][0].ToString();
                            SqlConnection.Close();
                            dataAdapter.Dispose();

                            #endregion

                            #endregion

                        }
                    }
                    #endregion

                }
                #endregion


            }
            #endregion
        }


        #endregion

        #region Submit Ingredient button
        private void btnSubmitIngrediant_Click(object sender, EventArgs e)
        {
            if (txtRecipeID.Text == string.Empty)
            {
                MessageBox.Show("Enter a recipe first!", "MissingInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNameOfIngrediants.Text == string.Empty || txtQuantityIngrediant.Text == string.Empty)
                {
                    MessageBox.Show("Submit name of the ingredient and the quantity", "MissingInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection.Open();
                    string InsertCommand = $"INSERT INTO Ingredient([Name],Quantity,Recipe_ID) Values('{txtNameOfIngrediants.Text}','{txtQuantityIngrediant.Text}',{txtRecipeID.Text})";
                    SqlCommand sqlCommand = new SqlCommand(InsertCommand, SqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.InsertCommand = sqlCommand;
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                    GetUserRecipes();
                    GetRecipeIngredient();
                    GetRecipesStep();
                    

                    DialogResult result;
                    result = MessageBox.Show("Ingrediant added do you want to add another ? ", "Ingrediant Added", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        txtNameOfIngrediants.Text = string.Empty;
                        txtQuantityIngrediant.Text = string.Empty;

                    }

                    SqlConnection.Close();
                    sqlDataAdapter.Dispose();
                }
            }
        }

        #endregion

        #region btnShowPendedUserRecipe
        private void btnShowPendedUserRecipe_Click(object sender, EventArgs e)
        {
            //chekc if user already has any recipes 
            SqlConnection.Open();
            string checkingCommand = $"Select [User].FirstName,Recipe.[Name] AS RecipeName,Recipe.[Description] as RecipeDescription, Category.[Name] AS RecipeCategory, Recipe.RecipeStatus From Recipe " +
                $"INNER JOIN Category ON Recipe.Category_ID = Category.CategoryID " +
                $"INNER JOIN[User] ON Recipe.[User_ID] = [User].UserID Where [User_ID] = {txtUserID.Text} ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(checkingCommand, SqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count ==  0)
            {
                MessageBox.Show($"Dear User {txtUserName.Text} you don't have any recipes add recipe first.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlConnection.Close();
                sqlDataAdapter.Dispose();

            }
            else
            {
                GetUserRecipes();
                SqlConnection.Close();
            }

            
        }


        #endregion

        #region ButtonSubmitStep


        private void btnSumbitStep_Click(object sender, EventArgs e)
        {
            if (txtRecipeID.Text == string.Empty)
            {
                MessageBox.Show("Enter a recipe first!", "MissingInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection.Open();
                string commando = $"SELECT Ingredient.IngredientID From Ingredient INNER JOIN Recipe on Recipe.RecipeID = Ingredient.Recipe_ID Where Recipe.RecipeID = {txtRecipeID.Text}";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commando, SqlConnection);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                if (data.Rows.Count > 0)
                {
                    string commando1 = $"INSERT INTO Step([Description],Recipe_ID) VALUES ('{txtIngrediantStepDescription.Text}',{txtRecipeID.Text})";
                    SqlCommand sqlCommand = new SqlCommand(commando1, SqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.InsertCommand = sqlCommand;
                    sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                    GetRecipesStep();
                    DialogResult result;
                    result = MessageBox.Show("Do you want to add another step to your Recipe ? ", "Steps", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        txtIngrediantStepDescription.Text = string.Empty;
                        SqlConnection.Close();
                        sqlDataAdapter.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("You have to create Ingredients to your Recipe first!", "Missing Ingredients", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SqlConnection.Close();
                }
            }

        }
        #endregion


        #region Show step and Ingrediant

        
        private void btnShowStepAndIngrediant_Click(object sender, EventArgs e)
        {
            GetRecipeIngredient();
            GetRecipesStep();
        }

        #endregion
    }







}



