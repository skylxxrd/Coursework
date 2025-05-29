namespace PIS_InfoSystem
{
    partial class AdminDesktop
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
            requestManagement = new Button();
            groupBox1 = new GroupBox();
            roleComboBox = new ComboBox();
            roleLabel = new Label();
            passwordLabel = new Label();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            removeEmployee = new Button();
            addEmployee = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            First_column = new DataGridViewTextBoxColumn();
            CreationTime = new DataGridViewTextBoxColumn();
            updateButton = new Button();
            groupBox3 = new GroupBox();
            reportTextBox = new TextBox();
            reportNameLabel = new Label();
            createReport = new Button();
            deleteReport = new Button();
            usersListButton = new Button();
            UnloginButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // requestManagement
            // 
            requestManagement.FlatAppearance.BorderColor = Color.Gray;
            requestManagement.FlatStyle = FlatStyle.Flat;
            requestManagement.Font = new Font("Roboto Light", 12F);
            requestManagement.Location = new Point(13, 268);
            requestManagement.Margin = new Padding(4);
            requestManagement.Name = "requestManagement";
            requestManagement.Size = new Size(379, 50);
            requestManagement.TabIndex = 1;
            requestManagement.Text = "Просмотр заявок клиентов";
            requestManagement.UseVisualStyleBackColor = true;
            requestManagement.Click += requestManagement_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(roleComboBox);
            groupBox1.Controls.Add(roleLabel);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(loginLabel);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(loginTextBox);
            groupBox1.Controls.Add(removeEmployee);
            groupBox1.Controls.Add(addEmployee);
            groupBox1.Location = new Point(13, 58);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(379, 203);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление пользователями";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Клиент", "Работник", "Админ" });
            roleComboBox.Location = new Point(132, 110);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(230, 27);
            roleComboBox.TabIndex = 13;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.Location = new Point(13, 110);
            roleLabel.Margin = new Padding(4, 0, 4, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(46, 19);
            roleLabel.TabIndex = 12;
            roleLabel.Text = "Роль";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(13, 75);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(65, 19);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(13, 40);
            loginLabel.Margin = new Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(54, 19);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "Логин";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Roboto Light", 12F);
            passwordTextBox.Location = new Point(132, 72);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(230, 27);
            passwordTextBox.TabIndex = 8;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Roboto Light", 12F);
            loginTextBox.Location = new Point(132, 37);
            loginTextBox.Margin = new Padding(4);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(230, 27);
            loginTextBox.TabIndex = 7;
            // 
            // removeEmployee
            // 
            removeEmployee.FlatAppearance.BorderColor = Color.Gray;
            removeEmployee.FlatStyle = FlatStyle.Flat;
            removeEmployee.Font = new Font("Roboto Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            removeEmployee.Location = new Point(132, 165);
            removeEmployee.Margin = new Padding(4);
            removeEmployee.Name = "removeEmployee";
            removeEmployee.Size = new Size(112, 31);
            removeEmployee.TabIndex = 5;
            removeEmployee.Text = "Удалить";
            removeEmployee.UseVisualStyleBackColor = true;
            removeEmployee.Click += removeEmployee_Click;
            // 
            // addEmployee
            // 
            addEmployee.FlatAppearance.BorderColor = Color.Gray;
            addEmployee.FlatStyle = FlatStyle.Flat;
            addEmployee.Font = new Font("Roboto Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addEmployee.Location = new Point(252, 165);
            addEmployee.Margin = new Padding(4);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(112, 31);
            addEmployee.TabIndex = 4;
            addEmployee.Text = "Добавить";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(updateButton);
            groupBox2.Location = new Point(402, 14);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(447, 506);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Недавние отчеты";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { First_column, CreationTime });
            dataGridView1.Location = new Point(8, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(424, 415);
            dataGridView1.TabIndex = 5;
            // 
            // First_column
            // 
            First_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            First_column.HeaderText = "Имя";
            First_column.Name = "First_column";
            First_column.ReadOnly = true;
            // 
            // CreationTime
            // 
            CreationTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreationTime.HeaderText = "Дата создания";
            CreationTime.Name = "CreationTime";
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.FlatAppearance.BorderColor = Color.Gray;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            updateButton.Location = new Point(8, 449);
            updateButton.Margin = new Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(424, 50);
            updateButton.TabIndex = 1;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(reportTextBox);
            groupBox3.Controls.Add(reportNameLabel);
            groupBox3.Controls.Add(createReport);
            groupBox3.Controls.Add(deleteReport);
            groupBox3.Location = new Point(15, 398);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(380, 122);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Управление отчетами";
            // 
            // reportTextBox
            // 
            reportTextBox.Location = new Point(193, 36);
            reportTextBox.Name = "reportTextBox";
            reportTextBox.Size = new Size(180, 27);
            reportTextBox.TabIndex = 10;
            // 
            // reportNameLabel
            // 
            reportNameLabel.AutoSize = true;
            reportNameLabel.Location = new Point(32, 39);
            reportNameLabel.Name = "reportNameLabel";
            reportNameLabel.Size = new Size(136, 19);
            reportNameLabel.TabIndex = 9;
            reportNameLabel.Text = "Название отчета";
            // 
            // createReport
            // 
            createReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createReport.FlatAppearance.BorderColor = Color.Gray;
            createReport.FlatStyle = FlatStyle.Flat;
            createReport.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createReport.Location = new Point(193, 79);
            createReport.Margin = new Padding(4);
            createReport.Name = "createReport";
            createReport.Size = new Size(180, 36);
            createReport.TabIndex = 6;
            createReport.Text = "Создать отчет";
            createReport.UseVisualStyleBackColor = true;
            createReport.Click += createReport_Click;
            // 
            // deleteReport
            // 
            deleteReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteReport.FlatAppearance.BorderColor = Color.Gray;
            deleteReport.FlatStyle = FlatStyle.Flat;
            deleteReport.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteReport.Location = new Point(7, 79);
            deleteReport.Margin = new Padding(4);
            deleteReport.Name = "deleteReport";
            deleteReport.Size = new Size(180, 36);
            deleteReport.TabIndex = 7;
            deleteReport.Text = "Удалить отчет";
            deleteReport.UseVisualStyleBackColor = true;
            deleteReport.Click += deleteReport_Click;
            // 
            // usersListButton
            // 
            usersListButton.FlatAppearance.BorderColor = Color.Gray;
            usersListButton.FlatStyle = FlatStyle.Flat;
            usersListButton.Font = new Font("Roboto Light", 12F);
            usersListButton.Location = new Point(13, 327);
            usersListButton.Margin = new Padding(4);
            usersListButton.Name = "usersListButton";
            usersListButton.Size = new Size(379, 50);
            usersListButton.TabIndex = 12;
            usersListButton.Text = "Просмотр всех работников и клиентов";
            usersListButton.UseVisualStyleBackColor = true;
            usersListButton.Click += usersListButton_Click;
            // 
            // UnloginButton
            // 
            UnloginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UnloginButton.FlatAppearance.BorderColor = Color.Gray;
            UnloginButton.FlatStyle = FlatStyle.Flat;
            UnloginButton.Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnloginButton.Location = new Point(13, 14);
            UnloginButton.Margin = new Padding(4);
            UnloginButton.Name = "UnloginButton";
            UnloginButton.Size = new Size(148, 36);
            UnloginButton.TabIndex = 11;
            UnloginButton.Text = "Разлогиниться";
            UnloginButton.UseVisualStyleBackColor = true;
            UnloginButton.Click += UnloginButton_Click;
            // 
            // AdminDesktop
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 534);
            Controls.Add(UnloginButton);
            Controls.Add(usersListButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(requestManagement);
            Font = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AdminDesktop";
            Text = "AdminDesktop";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button requestManagement;
        private GroupBox groupBox1;
        private Button addEmployee;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button removeEmployee;
        private GroupBox groupBox2;
        private Button updateButton;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox reportTextBox;
        private Label reportNameLabel;
        private Button deleteReport;
        private Button createReport;
        private Button usersListButton;
        private ComboBox roleComboBox;
        private Label roleLabel;
        private Button UnloginButton;
        private DataGridViewTextBoxColumn First_column;
        private DataGridViewTextBoxColumn CreationTime;
    }
}