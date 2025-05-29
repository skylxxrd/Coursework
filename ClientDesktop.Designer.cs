namespace PIS_InfoSystem
{
    partial class ClientDesktop
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
            createOrder = new Button();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UnloginButton
            // 
            UnloginButton.FlatAppearance.BorderColor = Color.Gray;
            UnloginButton.FlatStyle = FlatStyle.Flat;
            UnloginButton.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnloginButton.Location = new Point(13, 13);
            UnloginButton.Margin = new Padding(4);
            UnloginButton.Name = "UnloginButton";
            UnloginButton.Size = new Size(158, 36);
            UnloginButton.TabIndex = 12;
            UnloginButton.Text = "Разлогиниться";
            UnloginButton.UseVisualStyleBackColor = true;
            UnloginButton.Click += UnloginButton_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(630, 286);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // createOrder
            // 
            createOrder.FlatAppearance.BorderColor = Color.Gray;
            createOrder.FlatStyle = FlatStyle.Flat;
            createOrder.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createOrder.Location = new Point(334, 349);
            createOrder.Margin = new Padding(4);
            createOrder.Name = "createOrder";
            createOrder.Size = new Size(310, 36);
            createOrder.TabIndex = 14;
            createOrder.Text = "Создать заявку";
            createOrder.UseVisualStyleBackColor = true;
            createOrder.Click += createOrder_Click;
            // 
            // updateButton
            // 
            updateButton.FlatAppearance.BorderColor = Color.Gray;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            updateButton.Location = new Point(13, 349);
            updateButton.Margin = new Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(310, 36);
            updateButton.TabIndex = 15;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += button1_Click;
            // 
            // ClientDesktop
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 400);
            Controls.Add(updateButton);
            Controls.Add(createOrder);
            Controls.Add(dataGridView1);
            Controls.Add(UnloginButton);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ClientDesktop";
            Text = "Рабочий стол клиента";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UnloginButton;
        private DataGridView dataGridView1;
        private Button createOrder;
        private Button updateButton;
    }
}