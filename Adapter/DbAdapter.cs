// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using Microsoft.VisualBasic.ApplicationServices;
using PIS_InfoSystem.Model;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PIS_InfoSystem.Adapter
{
    public class DbAdapter
    {
        private readonly IRepository _db;

        public DbAdapter(IRepository repository)
        {
            _db = repository;
        }

        public Model.User? Login(string login, string password)
        {
            try
            {
                return _db.users
                    .Where(p => p.login == login && p.password == password)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении входа: {ex.Message}");
                return null;
            }
        }
        public int GenerateId()
        {
            return _db.users.Any() ? _db.users.Max(u => u.id) + 1 : 1;
        }
        // Работа с пользователями системы
        public void CreateUser(Model.User user)
        {
            _db.users.Add(user);
            _db.SaveChanges();
        }
        public void DeleteUser(Model.User user)
        {
            _db.users.Remove(user);
            _db.SaveChanges();
        }
        public List<Model.User> ReadUser()
        {
            return _db.users.ToList();
        }
        public Model.User? GetUserByLogin(string login)
        {
            return _db.users.FirstOrDefault(u => u.login == login);
        }
        // Работа с заявками в системе с учетки юзера
        public void CreateRequest(Repair_orders repair)
        {
            _db.repair_orders.Add(repair);
            _db.SaveChanges();
        }
        public List<Repair_orders> ReadAllRequest()
        {
            return _db.repair_orders.ToList();
        }
        public List<Repair_orders> ReadRequest(int userId)
        {
            return _db.repair_orders.Where(u => u.client_id == userId).ToList();
        }
        public void DeleteRequest(string orderNumber)
        {
            var request = _db.repair_orders.FirstOrDefault(r => r.order_number == orderNumber);

            if (request != null)
            {
                _db.repair_orders.Remove(request);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Заявка с номером " + orderNumber + " не найдена.");
            }
        }

        // ОТДЕЛЬНО: меняем статус заявки с учетки админа, это не для юзера
        public void UpdateRequestStatus(int repairOrderId, string newStatus)
        {
            var repairOrder = _db.repair_orders.Find(repairOrderId);
            repairOrder.status = newStatus;
            _db.SaveChanges();
        }

        // Работа со станками (Machines) в системе
        public void AddMachine(Machines machine)
        {
            _db.machines.Add(machine);
            _db.SaveChanges();
        }
        public void DeleteMachine(Machines machine)
        {
            _db.machines.Remove(machine);
            _db.SaveChanges();
        }
        public List<Machines> ReadMachines()
        {
            return _db.machines.ToList();
        }
        
        // Работа с починками

        public void AddRepair(Repairs repairs)
        {
            _db.repairs.Add(repairs);
            _db.SaveChanges();
        }

        public void DeleteRepair(Repairs repairs)
        {
            _db.repairs.Remove(repairs);
            _db.SaveChanges();
        }

        public List<Repairs> ReadRepairs()
        {
            return _db.repairs.ToList();
        }

        // Employee
        // Получаем заявки только работника
        public List<Repair_orders> ReadRequestByUserId(int userId)
        {
            return _db.repair_orders.Where(r => r.user_id == userId).ToList(); 
        }
        // Метод для обновления статуса заявки
        public void UpdateRequest(Repair_orders request)
        {
            _db.repair_orders.Update(request);
            _db.SaveChanges();
        }
    }
}
