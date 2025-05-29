namespace PIS_InfoSystem
{
    partial class loginForm
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
            loginLabel = new Label();
            passwordLabel = new Label();
            enterButton = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.ForeColor = SystemColors.ControlDarkDark;
            loginLabel.Location = new Point(49, 70);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(45, 19);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.ForeColor = SystemColors.ControlDarkDark;
            passwordLabel.Location = new Point(49, 108);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(71, 19);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // enterButton
            // 
            enterButton.BackColor = SystemColors.Control;
            enterButton.FlatAppearance.BorderColor = Color.LightGray;
            enterButton.FlatAppearance.BorderSize = 0;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enterButton.ForeColor = SystemColors.ControlDarkDark;
            enterButton.Location = new Point(136, 138);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(147, 37);
            enterButton.TabIndex = 2;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(136, 67);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(147, 27);
            loginTextBox.TabIndex = 3;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(136, 105);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(147, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(397, 212);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(enterButton);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Desktop;
            Name = "loginForm";
            Text = "swaga app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label passwordLabel;
        private Button enterButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}
