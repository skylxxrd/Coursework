// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Adapter;
using System.Text;
using System.Security.Cryptography;
using PIS_InfoSystem.Interface;

namespace PIS_InfoSystem
{
    public partial class loginForm : Form
    {
        ILogicUI logic = new Logic();
        public loginForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            var user = logic.Login(login, password);
            if (user != null)
            {
                switch(user.role)
                {
                    case "Админ":
                        AdminDesktop adminDesktop = new AdminDesktop();
                        adminDesktop.Show();
                        this.Hide();
                        break;
                    case "Работник":
                        EmployeeDesktop employeeDesktop = new EmployeeDesktop(user.id);
                        employeeDesktop.Show();
                        this.Hide();
                        break;
                    case "Клиент":
                        var clientForm = new ClientDesktop(user.id);
                        clientForm.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                loginTextBox.ForeColor = Color.Red;
                passwordTextBox.ForeColor = Color.Red;
            }
        }

        private void InitializeCustomComponents()
        {
            // Подписываемся на события изменения текста
            loginTextBox.TextChanged += UpdateButtonColor;
            passwordTextBox.TextChanged += UpdateButtonColor;

            enterButton.ForeColor = Color.Gray;
        }

        private void UpdateButtonColor(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                enterButton.ForeColor = Color.Black;
                loginTextBox.ForeColor = SystemColors.ControlText;
                passwordTextBox.ForeColor = SystemColors.ControlText;
            }
            else
            {
                enterButton.ForeColor = Color.Gray;
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
