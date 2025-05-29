// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using Microsoft.VisualBasic.Logging;
using PIS_InfoSystem.Adapter;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIS_InfoSystem
{
    public partial class requestCreatePage : Form
    {
        private int clientId;
        ILogicClientUI logic = new Logic();
        public requestCreatePage(int userId)
        {
            InitializeComponent();
            clientId = userId;
            LoadRepairsToComboBox();
            LoadMachinesToComboBox();
        }

        private void createRequestButton_Click(object sender, EventArgs e)
        {
            if (ComboBoxMachines.SelectedItem == null || ComboBoxRepairs.SelectedItem == null)
            {
                MessageBox.Show("Выберите оборудование и тип ремонта.");
                return;
            }

            var selectedMachine = (Machines)ComboBoxMachines.SelectedItem;
            var selectedRepair = (Repairs)ComboBoxRepairs.SelectedItem;

            int machineId = selectedMachine.id;
            int repairId = selectedRepair.id;

            string orderNumber = logic.GenerateOrderNumber();

            logic.CreateRequest(machineId, repairId, clientId, orderNumber);

            MessageBox.Show("Заявка успешно создана!");
            ComboBoxMachines.SelectedIndex = -1;
            ComboBoxRepairs.SelectedIndex = -1;
        }

        private void LoadMachinesToComboBox()
        {
            var machines = logic.LoadMachines();
            ComboBoxMachines.DataSource = machines;
            ComboBoxMachines.DisplayMember = "name";
            ComboBoxMachines.ValueMember = "id";
        }

        private void LoadRepairsToComboBox()
        {
            var repairs = logic.LoadRepairs();
            ComboBoxRepairs.DataSource = repairs;
            ComboBoxRepairs.DisplayMember = "name";
            ComboBoxRepairs.ValueMember = "id";
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
