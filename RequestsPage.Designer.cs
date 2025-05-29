namespace PIS_InfoSystem
{
    partial class RequestsPage
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
            goBackbutton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // goBackbutton
            // 
            goBackbutton.Location = new Point(13, 13);
            goBackbutton.Margin = new Padding(4);
            goBackbutton.Name = "goBackbutton";
            goBackbutton.Size = new Size(96, 27);
            goBackbutton.TabIndex = 0;
            goBackbutton.Text = "Назад";
            goBackbutton.UseVisualStyleBackColor = true;
            goBackbutton.Click += goBackbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 48);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1003, 473);
            dataGridView1.TabIndex = 1;
            // 
            // RequestsPage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 534);
            Controls.Add(dataGridView1);
            Controls.Add(goBackbutton);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "RequestsPage";
            Text = "Таблица заявок клиентов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goBackbutton;
        private DataGridView dataGridView1;
    }
}