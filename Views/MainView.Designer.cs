namespace StudentRegistry
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            addStudentButton = new Button();
            delStudentButton = new Button();
            logInButton = new Button();
            logOutButton = new Button();
            studentAwardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(31, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1024, 219);
            dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSourceChanged += bindingSource1_DataSourceChanged;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(31, 254);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(118, 29);
            addStudentButton.TabIndex = 1;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // delStudentButton
            // 
            delStudentButton.Location = new Point(31, 289);
            delStudentButton.Name = "delStudentButton";
            delStudentButton.Size = new Size(174, 29);
            delStudentButton.TabIndex = 2;
            delStudentButton.Text = "Edit / Delete Student";
            delStudentButton.UseVisualStyleBackColor = true;
            delStudentButton.Click += delStudentButton_Click;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(961, 374);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(961, 409);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 4;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // studentAwardButton
            // 
            studentAwardButton.Location = new Point(31, 409);
            studentAwardButton.Name = "studentAwardButton";
            studentAwardButton.Size = new Size(174, 29);
            studentAwardButton.TabIndex = 5;
            studentAwardButton.Text = "Get Student Award!";
            studentAwardButton.UseVisualStyleBackColor = true;
            studentAwardButton.Click += studentAwardButton_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(studentAwardButton);
            Controls.Add(logOutButton);
            Controls.Add(logInButton);
            Controls.Add(delStudentButton);
            Controls.Add(addStudentButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainView";
            Text = "Student Registry";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button addStudentButton;
        private Button delStudentButton;
        private Button logInButton;
        private Button logOutButton;
        private Button studentAwardButton;
    }
}
