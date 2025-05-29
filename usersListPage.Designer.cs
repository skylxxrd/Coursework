namespace PIS_InfoSystem
{
    partial class usersListPage
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Location = new Point(15, 14);
            goBackButton.Margin = new Padding(4);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(96, 27);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "Назад";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(593, 464);
            dataGridView1.TabIndex = 1;
            // 
            // usersListPage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 534);
            Controls.Add(dataGridView1);
            Controls.Add(goBackButton);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "usersListPage";
            Text = "usersListPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goBackButton;
        private DataGridView dataGridView1;
    }
}