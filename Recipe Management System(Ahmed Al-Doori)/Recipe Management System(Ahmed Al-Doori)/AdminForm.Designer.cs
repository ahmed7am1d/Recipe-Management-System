namespace Recipe_Management_System_Ahmed_Al_Doori_
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.dgvPendedRecipes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUserRecipeIngredient = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvRecipeUserStep = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowIngredientandStep = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRecipeID = new System.Windows.Forms.TextBox();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendedRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRecipeIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeUserStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendedRecipes
            // 
            this.dgvPendedRecipes.AllowUserToAddRows = false;
            this.dgvPendedRecipes.AllowUserToDeleteRows = false;
            this.dgvPendedRecipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPendedRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendedRecipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPendedRecipes.Location = new System.Drawing.Point(406, 34);
            this.dgvPendedRecipes.Name = "dgvPendedRecipes";
            this.dgvPendedRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendedRecipes.Size = new System.Drawing.Size(549, 152);
            this.dgvPendedRecipes.TabIndex = 1;
            this.dgvPendedRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendedRecipes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(403, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users Recipes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(22, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(22, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "User Recipe Name:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnUpdateInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateInfo.Location = new System.Drawing.Point(26, 301);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(176, 45);
            this.btnUpdateInfo.TabIndex = 10;
            this.btnUpdateInfo.Text = "Update recipe";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Recipe Status:";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(241, 100);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(121, 20);
            this.txtUserID.TabIndex = 15;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(241, 135);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 16;
            // 
            // txtUserRecipeName
            // 
            this.txtUserRecipeName.Enabled = false;
            this.txtUserRecipeName.Location = new System.Drawing.Point(241, 197);
            this.txtUserRecipeName.Name = "txtUserRecipeName";
            this.txtUserRecipeName.Size = new System.Drawing.Size(121, 20);
            this.txtUserRecipeName.TabIndex = 17;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Location = new System.Drawing.Point(241, 233);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeStatus.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(109, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(96, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(971, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "User\'s Recipe Ingredient:";
            // 
            // dgvUserRecipeIngredient
            // 
            this.dgvUserRecipeIngredient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvUserRecipeIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRecipeIngredient.Location = new System.Drawing.Point(974, 37);
            this.dgvUserRecipeIngredient.Name = "dgvUserRecipeIngredient";
            this.dgvUserRecipeIngredient.Size = new System.Drawing.Size(439, 152);
            this.dgvUserRecipeIngredient.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(753, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "User\'s Recipes Steps:\r\n";
            // 
            // dgvRecipeUserStep
            // 
            this.dgvRecipeUserStep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRecipeUserStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeUserStep.Location = new System.Drawing.Point(756, 211);
            this.dgvRecipeUserStep.Name = "dgvRecipeUserStep";
            this.dgvRecipeUserStep.Size = new System.Drawing.Size(439, 146);
            this.dgvRecipeUserStep.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recipe_Management_System_Ahmed_Al_Doori_.Properties.Resources.engineer_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Recipe_Management_System_Ahmed_Al_Doori_.Properties.Resources.blackwave2;
            this.pictureBox2.Location = new System.Drawing.Point(-9, 424);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1495, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnShowIngredientandStep
            // 
            this.btnShowIngredientandStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowIngredientandStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowIngredientandStep.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnShowIngredientandStep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowIngredientandStep.Location = new System.Drawing.Point(128, 352);
            this.btnShowIngredientandStep.Name = "btnShowIngredientandStep";
            this.btnShowIngredientandStep.Size = new System.Drawing.Size(176, 45);
            this.btnShowIngredientandStep.TabIndex = 25;
            this.btnShowIngredientandStep.Text = "Show Ingredient and steps";
            this.btnShowIngredientandStep.UseVisualStyleBackColor = false;
            this.btnShowIngredientandStep.Click += new System.EventHandler(this.btnShowIngredientandStep_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(23, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "RecipeID: ";
            // 
            // txtRecipeID
            // 
            this.txtRecipeID.Enabled = false;
            this.txtRecipeID.Location = new System.Drawing.Point(241, 166);
            this.txtRecipeID.Name = "txtRecipeID";
            this.txtRecipeID.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeID.TabIndex = 27;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnDeleteRecipe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(224, 301);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(176, 45);
            this.btnDeleteRecipe.TabIndex = 28;
            this.btnDeleteRecipe.Text = "DeleteRecipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 542);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.txtRecipeID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnShowIngredientandStep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvUserRecipeIngredient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvRecipeUserStep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRecipeStatus);
            this.Controls.Add(this.txtUserRecipeName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPendedRecipes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendedRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRecipeIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeUserStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPendedRecipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserRecipeName;
        private System.Windows.Forms.TextBox txtRecipeStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUserRecipeIngredient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvRecipeUserStep;
        private System.Windows.Forms.Button btnShowIngredientandStep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRecipeID;
        private System.Windows.Forms.Button btnDeleteRecipe;
    }
}