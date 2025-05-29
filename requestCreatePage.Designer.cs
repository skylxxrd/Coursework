namespace PIS_InfoSystem
{
    partial class requestCreatePage
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
            goBackButton = new Button();
            createRequestButton = new Button();
            ComboBoxRepairs = new ComboBox();
            ComboBoxMachines = new ComboBox();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(13, 13);
            goBackButton.Margin = new Padding(4);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(156, 26);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "Назад";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // createRequestButton
            // 
            createRequestButton.Location = new Point(13, 56);
            createRequestButton.Margin = new Padding(4);
            createRequestButton.Name = "createRequestButton";
            createRequestButton.Size = new Size(156, 27);
            createRequestButton.TabIndex = 1;
            createRequestButton.Text = "Создать заявку";
            createRequestButton.UseVisualStyleBackColor = true;
            createRequestButton.Click += createRequestButton_Click;
            // 
            // ComboBoxRepairs
            // 
            ComboBoxRepairs.FormattingEnabled = true;
            ComboBoxRepairs.Items.AddRange(new object[] { "Engine_overhaul" });
            ComboBoxRepairs.Location = new Point(195, 57);
            ComboBoxRepairs.Name = "ComboBoxRepairs";
            ComboBoxRepairs.Size = new Size(238, 27);
            ComboBoxRepairs.TabIndex = 3;
            // 
            // ComboBoxMachines
            // 
            ComboBoxMachines.FormattingEnabled = true;
            ComboBoxMachines.Location = new Point(195, 12);
            ComboBoxMachines.Name = "ComboBoxMachines";
            ComboBoxMachines.Size = new Size(238, 27);
            ComboBoxMachines.TabIndex = 4;
            // 
            // requestCreatePage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 103);
            Controls.Add(ComboBoxMachines);
            Controls.Add(ComboBoxRepairs);
            Controls.Add(createRequestButton);
            Controls.Add(goBackButton);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "requestCreatePage";
            Text = "requestCreatePage";
            ResumeLayout(false);
        }

        #endregion

        private Button goBackButton;
        private Button createRequestButton;
        private ComboBox ComboBoxRepairs;
        private ComboBox ComboBoxMachines;
    }
}