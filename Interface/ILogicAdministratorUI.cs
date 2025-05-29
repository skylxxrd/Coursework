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
    internal interface ILogicAdministratorUI
    {
        // Статус и заявки
        void StatusChange(int repairOrderId, string status);
        List<Repair_orders> LoadAllRequest();

        // Отчеты
        void CreateReport(string name);
        void RemoveReport(string name);
        string[] LoadReports();

        // LoadUsers() общий для всех юзеров
        void AddUser(string login, string password, string role);
        void RemoveUser(string login, string password, string role);
        List<User> LoadUsers();
    }
}
