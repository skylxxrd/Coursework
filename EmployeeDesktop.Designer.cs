namespace PIS_InfoSystem
{
    partial class EmployeeDesktop
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
            UnloginButton = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // UnloginButton
            // 
            UnloginButton.FlatAppearance.BorderColor = Color.Gray;
            UnloginButton.FlatStyle = FlatStyle.Flat;
            UnloginButton.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnloginButton.Location = new Point(13, 15);
            UnloginButton.Margin = new Padding(4);
            UnloginButton.Name = "UnloginButton";
            UnloginButton.Size = new Size(148, 36);
            UnloginButton.TabIndex = 12;
            UnloginButton.Text = "Разлогиниться";
            UnloginButton.UseVisualStyleBackColor = true;
            UnloginButton.Click += UnloginButton_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 417);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(464, 58);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(441, 417);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // EmployeeDesktop
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 487);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(UnloginButton);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "EmployeeDesktop";
            Text = "Рабочий стол сотрудника";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UnloginButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}