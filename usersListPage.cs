// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Adapter;
using PIS_InfoSystem.Interface;
using System.Data;

namespace PIS_InfoSystem
{
    public partial class usersListPage : Form
    {
        ILogicAdministratorUI logic = new Logic();
        public usersListPage()
        {
            InitializeComponent();
            LoadUsersToGrid(); // Подписываемся на загрузку формы
        }
        private void LoadUsersToGrid()
        {
            var users = logic.LoadUsers();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = users;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["login"].HeaderText = "Логин";
            dataGridView1.Columns["password"].HeaderText = "Пароль";
            dataGridView1.Columns["role"].HeaderText = "Роль";

            // Скрываем пароли из безопасности
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void goBackButton_Click_1(object sender, EventArgs e)
        {
            AdminDesktop adminDesktop = new AdminDesktop();
            adminDesktop.Show();
            this.Close();
        }
    }
}
