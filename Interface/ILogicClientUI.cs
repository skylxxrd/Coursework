// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIS_InfoSystem.Model;

namespace PIS_InfoSystem.Interface
{
    internal interface ILogicClientUI
    {
        void CreateRequest(int machineId, int repairId, int clientId, string orderNumber);
        void RemoveRequest(string orderNumber);
        List<Repair_orders> LoadClientRequest(int clientId);
        List<Repairs> LoadRepairs();
        List<Machines> LoadMachines();
        string GenerateOrderNumber();
    }
}
