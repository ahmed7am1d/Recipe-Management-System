namespace Recipe_Management_System_Ahmed_Al_Doori_
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowStepAndIngrediant = new System.Windows.Forms.Button();
            this.txtRecipeID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowPendedUserRecipe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmitRecipe = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtRecipeDescription = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSumbitStep = new System.Windows.Forms.Button();
            this.btnSubmitIngrediant = new System.Windows.Forms.Button();
            this.txtQuantityIngrediant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngrediantStepDescription = new System.Windows.Forms.RichTextBox();
            this.txtNameOfIngrediants = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRecipeStepAndIngredient = new System.Windows.Forms.DataGridView();
            this.dgvPendedRecipe = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvRecipesSteps = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvApprovedRecipes = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeStepAndIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendedRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowStepAndIngrediant);
            this.groupBox1.Controls.Add(this.txtRecipeID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnShowPendedUserRecipe);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSubmitRecipe);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.txtRecipeDescription);
            this.groupBox1.Controls.Add(this.txtRecipeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnShowStepAndIngrediant
            // 
            this.btnShowStepAndIngrediant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowStepAndIngrediant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStepAndIngrediant.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnShowStepAndIngrediant.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowStepAndIngrediant.Location = new System.Drawing.Point(37, 365);
            this.btnShowStepAndIngrediant.Name = "btnShowStepAndIngrediant";
            this.btnShowStepAndIngrediant.Size = new System.Drawing.Size(330, 52);
            this.btnShowStepAndIngrediant.TabIndex = 16;
            this.btnShowStepAndIngrediant.Text = "Show My Recipes Ingredients and Steps";
            this.btnShowStepAndIngrediant.UseVisualStyleBackColor = false;
            this.btnShowStepAndIngrediant.Click += new System.EventHandler(this.btnShowStepAndIngrediant_Click);
            // 
            // txtRecipeID
            // 
            this.txtRecipeID.Enabled = false;
            this.txtRecipeID.Location = new System.Drawing.Point(277, 248);
            this.txtRecipeID.Name = "txtRecipeID";
            this.txtRecipeID.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeID.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(120, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Recipe ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(277, 83);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(121, 20);
            this.txtUserID.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(120, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "User ID:";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(277, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(120, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "UserName:";
            // 
            // btnShowPendedUserRecipe
            // 
            this.btnShowPendedUserRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowPendedUserRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPendedUserRecipe.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnShowPendedUserRecipe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowPendedUserRecipe.Location = new System.Drawing.Point(37, 307);
            this.btnShowPendedUserRecipe.Name = "btnShowPendedUserRecipe";
            this.btnShowPendedUserRecipe.Size = new System.Drawing.Size(150, 52);
            this.btnShowPendedUserRecipe.TabIndex = 1;
            this.btnShowPendedUserRecipe.Text = "Show my recipes";
            this.btnShowPendedUserRecipe.UseVisualStyleBackColor = false;
            this.btnShowPendedUserRecipe.Click += new System.EventHandler(this.btnShowPendedUserRecipe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmitRecipe
            // 
            this.btnSubmitRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRecipe.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnSubmitRecipe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitRecipe.Location = new System.Drawing.Point(217, 307);
            this.btnSubmitRecipe.Name = "btnSubmitRecipe";
            this.btnSubmitRecipe.Size = new System.Drawing.Size(150, 52);
            this.btnSubmitRecipe.TabIndex = 6;
            this.btnSubmitRecipe.Text = "Submit Recipe";
            this.btnSubmitRecipe.UseVisualStyleBackColor = false;
            this.btnSubmitRecipe.Click += new System.EventHandler(this.btnSubmitRecipe_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "BreakFast",
            "Lunch",
            "Dinner",
            "Apptizer",
            "Dessert",
            "Beverage",
            "Juice"});
            this.comboBoxCategory.Location = new System.Drawing.Point(277, 208);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // txtRecipeDescription
            // 
            this.txtRecipeDescription.Location = new System.Drawing.Point(277, 167);
            this.txtRecipeDescription.Name = "txtRecipeDescription";
            this.txtRecipeDescription.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeDescription.TabIndex = 4;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(277, 121);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(120, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipe Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(120, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipe Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(120, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSumbitStep);
            this.groupBox2.Controls.Add(this.btnSubmitIngrediant);
            this.groupBox2.Controls.Add(this.txtQuantityIngrediant);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIngrediantStepDescription);
            this.groupBox2.Controls.Add(this.txtNameOfIngrediants);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(408, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 459);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipe Ingrediants";
            // 
            // btnSumbitStep
            // 
            this.btnSumbitStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSumbitStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumbitStep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSumbitStep.Location = new System.Drawing.Point(188, 332);
            this.btnSumbitStep.Name = "btnSumbitStep";
            this.btnSumbitStep.Size = new System.Drawing.Size(175, 39);
            this.btnSumbitStep.TabIndex = 13;
            this.btnSumbitStep.Text = "Submit Step";
            this.btnSumbitStep.UseVisualStyleBackColor = false;
            this.btnSumbitStep.Click += new System.EventHandler(this.btnSumbitStep_Click);
            // 
            // btnSubmitIngrediant
            // 
            this.btnSubmitIngrediant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitIngrediant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitIngrediant.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmitIngrediant.Location = new System.Drawing.Point(188, 125);
            this.btnSubmitIngrediant.Name = "btnSubmitIngrediant";
            this.btnSubmitIngrediant.Size = new System.Drawing.Size(175, 39);
            this.btnSubmitIngrediant.TabIndex = 12;
            this.btnSubmitIngrediant.Text = "Submit Ingrediant";
            this.btnSubmitIngrediant.UseVisualStyleBackColor = false;
            this.btnSubmitIngrediant.Click += new System.EventHandler(this.btnSubmitIngrediant_Click);
            // 
            // txtQuantityIngrediant
            // 
            this.txtQuantityIngrediant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtQuantityIngrediant.Location = new System.Drawing.Point(188, 78);
            this.txtQuantityIngrediant.Name = "txtQuantityIngrediant";
            this.txtQuantityIngrediant.Size = new System.Drawing.Size(175, 20);
            this.txtQuantityIngrediant.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(8, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Step Description:";
            // 
            // txtIngrediantStepDescription
            // 
            this.txtIngrediantStepDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIngrediantStepDescription.Location = new System.Drawing.Point(188, 219);
            this.txtIngrediantStepDescription.Name = "txtIngrediantStepDescription";
            this.txtIngrediantStepDescription.Size = new System.Drawing.Size(175, 95);
            this.txtIngrediantStepDescription.TabIndex = 3;
            this.txtIngrediantStepDescription.Text = "";
            // 
            // txtNameOfIngrediants
            // 
            this.txtNameOfIngrediants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNameOfIngrediants.Location = new System.Drawing.Point(188, 35);
            this.txtNameOfIngrediants.Name = "txtNameOfIngrediants";
            this.txtNameOfIngrediants.Size = new System.Drawing.Size(175, 20);
            this.txtNameOfIngrediants.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ingrediant Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrediant Name:";
            // 
            // dgvRecipeStepAndIngredient
            // 
            this.dgvRecipeStepAndIngredient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRecipeStepAndIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeStepAndIngredient.Location = new System.Drawing.Point(27, 491);
            this.dgvRecipeStepAndIngredient.Name = "dgvRecipeStepAndIngredient";
            this.dgvRecipeStepAndIngredient.Size = new System.Drawing.Size(356, 172);
            this.dgvRecipeStepAndIngredient.TabIndex = 14;
            // 
            // dgvPendedRecipe
            // 
            this.dgvPendedRecipe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPendedRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendedRecipe.Location = new System.Drawing.Point(822, 319);
            this.dgvPendedRecipe.Name = "dgvPendedRecipe";
            this.dgvPendedRecipe.Size = new System.Drawing.Size(547, 167);
            this.dgvPendedRecipe.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(822, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "My Recipes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(29, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "My Recipes Ingredients:\r\n";
            // 
            // dgvRecipesSteps
            // 
            this.dgvRecipesSteps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRecipesSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipesSteps.Location = new System.Drawing.Point(401, 491);
            this.dgvRecipesSteps.Name = "dgvRecipesSteps";
            this.dgvRecipesSteps.Size = new System.Drawing.Size(356, 172);
            this.dgvRecipesSteps.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(398, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "My Recipes steps:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Recipe_Management_System_Ahmed_Al_Doori_.Properties.Resources.wave;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 579);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1582, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dgvApprovedRecipes
            // 
            this.dgvApprovedRecipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvApprovedRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprovedRecipes.Location = new System.Drawing.Point(819, 47);
            this.dgvApprovedRecipes.Name = "dgvApprovedRecipes";
            this.dgvApprovedRecipes.Size = new System.Drawing.Size(550, 167);
            this.dgvApprovedRecipes.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(819, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Users Approved Recipes:\r\n";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 712);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvApprovedRecipes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvRecipesSteps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvPendedRecipe);
            this.Controls.Add(this.dgvRecipeStepAndIngredient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeStepAndIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendedRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipesSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitRecipe;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtRecipeDescription;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowPendedUserRecipe;
        private System.Windows.Forms.TextBox txtQuantityIngrediant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtIngrediantStepDescription;
        private System.Windows.Forms.TextBox txtNameOfIngrediants;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecipeID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmitIngrediant;
        private System.Windows.Forms.Button btnSumbitStep;
        private System.Windows.Forms.DataGridView dgvPendedRecipe;
        private System.Windows.Forms.DataGridView dgvRecipeStepAndIngredient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowStepAndIngrediant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvRecipesSteps;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvApprovedRecipes;
        private System.Windows.Forms.Label label13;
    }
}