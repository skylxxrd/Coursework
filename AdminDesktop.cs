// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Text;
using System.Security.Cryptography;
using PIS_InfoSystem.Adapter;
using PIS_InfoSystem.Interface;

namespace PIS_InfoSystem
{
    public partial class AdminDesktop : Form
    {
        ILogicAdministratorUI logic = new Logic();
        public AdminDesktop()
        {
            InitializeComponent();
            LoadReportsToGrid();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadReportsToGrid();
        }

        private void LoadReportsToGrid()
        {
            string[] reports = logic.LoadReports();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Имя файла");
            dataGridView1.Columns.Add("CreationTime", "Дата создания");

            foreach (var line in reports)
            {
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    dataGridView1.Rows.Add(parts[0], parts[1]);
                }
            }
        }

        private void requestManagement_Click(object sender, EventArgs e)
        {
            RequestsPage requestsPage = new RequestsPage();
            requestsPage.Show();
            this.Hide();
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            string reportName = reportTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(reportName))
            {
                MessageBox.Show("Введите имя отчёта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            logic.CreateReport(reportName);
            LoadReportsToGrid();
        }

        private void deleteReport_Click(object sender, EventArgs e)
        {
            string reportName = reportTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(reportName))
            {
                MessageBox.Show("Введите имя отчёта для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            logic.RemoveReport(reportName);
            LoadReportsToGrid(); // Обновляем список отчётов в гриде
        }

        private void usersListButton_Click(object sender, EventArgs e)
        {
            usersListPage usersListPage = new usersListPage();
            usersListPage.Show();
            this.Hide();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string role = roleComboBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            try
            {
                logic.AddUser(login, password, role);
                MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            loginTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string role = roleComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }
            try
            {
                logic.RemoveUser(login, password, role);
                MessageBox.Show("Сотрудник успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            loginTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void UnloginButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
