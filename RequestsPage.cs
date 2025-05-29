// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Interface;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PIS_InfoSystem
{
    public partial class RequestsPage : Form
    {
        ILogicAdministratorUI logic = new Logic();

        public RequestsPage()
        {
            InitializeComponent();
            LoadData();
            SetupStatusColumn();
            dataGridView1.CellEndEdit += OnCellEndEdit;
        }

        private void SetupStatusColumn()
        {
            if (dataGridView1.Columns["status"] is not DataGridViewColumn statusCol) return;

            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "status",
                HeaderText = "Статус",
                DataPropertyName = "status", // Привязка к источнику данных
                DataSource = new[] { "Не начато", "В процессе","Выполнено" },
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                FlatStyle = FlatStyle.Flat
            };

            dataGridView1.Columns.Remove(statusCol);
            dataGridView1.Columns.Insert(statusCol.Index, comboBoxColumn);
        }

        private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "status") return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["id"].Value is not int repairId) return;

            var newStatus = row.Cells["status"].Value?.ToString();

            
            logic.StatusChange(repairId, newStatus);
        }
        private void LoadData()
        {
            // Вызываем логику загрузки данных

            var repairs = logic.LoadAllRequest();

            if (repairs != null && repairs.Any())
            {
                dataGridView1.DataSource = repairs;
            }
            else dataGridView1.DataSource = null; // Очистка грида
        }

        private void goBackbutton_Click(object sender, EventArgs e)
        {
            new AdminDesktop().Show();
            Close();
        }
    }
}