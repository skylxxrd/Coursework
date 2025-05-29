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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_InfoSystem
{
    public partial class ClientDesktop : Form
    {
        ILogicClientUI logic = new Logic();
        private int _clientId;
        public ClientDesktop()
        {
            InitializeComponent();
        }
        public ClientDesktop(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadRequestsToGrid(_clientId); // загрузка заявок по clientId
        }

        private void LoadRequestsToGrid(int clientId)
        {
            dataGridView1.AutoGenerateColumns = true;
            var requests = logic.LoadClientRequest(clientId);
            dataGridView1.DataSource = requests;
        }
        private void UnloginButton_Click_1(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик был не по заголовкам
            if (e.RowIndex >= 0)
            {
                // Получаем текущую строку
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                var request = row.DataBoundItem as Repair_orders;

                if (request != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Вы уверены, что хотите удалить заявку №{request.order_number}?",
                        "Удаление заявки",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        logic.RemoveRequest(request.order_number);
                        LoadRequestsToGrid(_clientId);
                    }
                }
            }
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            requestCreatePage requestCreate = new requestCreatePage(_clientId);
            requestCreate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRequestsToGrid(_clientId);
        }
    }
}
