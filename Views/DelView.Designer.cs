namespace StudentRegistry.Views
{
    partial class DelView
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
            confirmDelButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // confirmDelButton
            // 
            confirmDelButton.Location = new Point(58, 389);
            confirmDelButton.Name = "confirmDelButton";
            confirmDelButton.Size = new Size(286, 29);
            confirmDelButton.TabIndex = 0;
            confirmDelButton.Text = "Confirm Delete";
            confirmDelButton.UseVisualStyleBackColor = true;
            confirmDelButton.Click += confirmDelButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(455, 389);
            backButton.Name = "backButton";
            backButton.Size = new Size(286, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // DelView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(confirmDelButton);
            Name = "DelView";
            Text = "DelView";
            ResumeLayout(false);
        }

        #endregion

        private Button confirmDelButton;
        private Button backButton;
    }
}