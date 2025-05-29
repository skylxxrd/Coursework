// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Interface;
using PIS_InfoSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_InfoSystem
{
    public partial class EmployeeDesktop : Form
    {
        ILogicEmployeeUI logic = new Logic();
        private int _userId;
        public EmployeeDesktop(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadAllRequests();
            LoadUserRequests();
        }

        private void UnloginButton_Click_1(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void LoadAllRequests()
        {
            var allRequests = logic.LoadAllRequest().Where(r => r.status != "Выполнено").ToList();
            dataGridView1.DataSource = allRequests;
        }

        private void LoadUserRequests()
        {
            var userRequests = logic.GetRequestsByUserId(_userId).Where(r => r.status != "Выполнено").ToList();
            dataGridView2.DataSource = userRequests;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var request = row.DataBoundItem as Repair_orders;

                if (request == null) return;

                var confirm = MessageBox.Show(
                    "Вы уверены, что хотите взять заявку в обработку?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes && request.status != "В процессе")
                {
                    request.status = "В процессе";
                    request.user_id = _userId;

                    logic.UpdateRequest(request);

                    LoadAllRequests();
                    LoadUserRequests();
                }
                else
                {
                    MessageBox.Show("Вы не можете взять эту заявку в обработку");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex];
                var request = row.DataBoundItem as Repair_orders;

                if (request == null) return;

                var confirm = MessageBox.Show(
                    "Вы уверены, что хотите отметить заявку как выполненную?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    request.status = "Выполнено";

                    logic.UpdateRequest(request);

                    LoadAllRequests();
                    LoadUserRequests();
                }
            }
        }
    }
}
