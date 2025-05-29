// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Adapter;
using System.Text;
using PIS_InfoSystem.Model;
using PIS_InfoSystem.Interface;
using System.Linq;
using System;
namespace PIS_InfoSystem
{
    public class Logic : ILogicUI, ILogicAdministratorUI, ILogicClientUI, ILogicEmployeeUI
    {
        private DbAdapter Facade;
        private HashPassword HashPassword = new();
        public Logic(IRepository? dataContext = null)
        {
            Facade = new DbAdapter(new DataContext());
            if (dataContext is not null)
            {
                Facade = new DbAdapter(dataContext);
            }
        }

        public User? Login(string login, string password)
        {
            string hashedPassword = HashPassword.HashedPassword(password);
            return Facade.Login(login, hashedPassword);
        }

        // ILogicAdministratorUI | AdminDesktop

        // LoadUsers() загружает всех юзеров
        public void AddUser(string login, string password, string role)
        {
            try
            {
                var user = new User
                {
                    login = login,
                    password = HashPassword.HashedPassword(password),
                    role = role
                };

                user.id = Facade.GenerateId();
                Facade.CreateUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}\n\n{ex.StackTrace}");
            }
        }
        public void RemoveUser(string login, string password, string role)
        {
            var existingUser = Facade.GetUserByLogin(login); // ← Получаем реального пользователя из БД
            if (existingUser != null)
            {
                Facade.DeleteUser(existingUser);
            }
            else
            {
                throw new Exception("Пользователь не найден.");
            }
        }
        public List<User> LoadUsers()
        {
            return Facade.ReadUser();
        }

        // Reports
        public void CreateReport(string name)
        {
            string reportsPath = Path.Combine(Application.StartupPath, "Reports");

            if (!Directory.Exists(reportsPath))
                Directory.CreateDirectory(reportsPath);

            string fileName = Path.GetFileNameWithoutExtension(name) + ".txt";
            string filePath = Path.Combine(reportsPath, fileName);

            string content = $"Отчёт создан: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n";
            content += "===============================\n";
            content += "Это тестовый отчётный файл.\n";
            content += "тралалеро тралала, шпиониро голубиро\n";

            File.WriteAllText(filePath, content);
        }
        public void RemoveReport(string name)
        {
            string reportFolder = Path.Combine(Application.StartupPath, "Reports");

            string fileName = name.Trim() + ".txt";
            string filePath = Path.Combine(reportFolder, fileName);

            if (!File.Exists(filePath))
            {
                return;
            }

            try
            {
                File.Delete(filePath);
                MessageBox.Show($"Отчет '{fileName}' успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string[] LoadReports()
        {
            try
            {
                string reportsPath = Path.Combine(Application.StartupPath, "Reports");

                if (!Directory.Exists(reportsPath))
                {
                    MessageBox.Show("Папка Reports не найдена.");
                    return Array.Empty<string>();
                }

                var files = new DirectoryInfo(reportsPath).GetFiles();

                List<string> reportList = new List<string>();

                foreach (var file in files)
                {
                    string fileName = file.Name;
                    string creationTime = file.CreationTime.ToString("yyyy-MM-dd HH:mm:ss");

                    reportList.Add($"{fileName}|{creationTime}");
                }

                return reportList.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return Array.Empty<string>();
            }
        }

        // Request for Admin

        public List<Repair_orders> LoadAllRequest()
        {
            return Facade.ReadAllRequest();
        }

        public void StatusChange(int repairOrderId, string status)
        {
            Facade.UpdateRequestStatus(repairOrderId, status);
        }

        // Request for Employee

        public List<Repair_orders> GetRequestsByUserId(int userId)
        {
            return Facade.ReadRequestByUserId(userId); // реализуй в Facade
        }

        // ILogicClientUI | ClientDesktop
        // Заявки Клиента
        public void CreateRequest(int machineId, int repairId, int clientId, string orderNumber)
        {
            var request = new Repair_orders
            {
                machine_id = machineId,
                repair_id = repairId,
                client_id = clientId,
                order_number = orderNumber,
                status = "Не начато"
            };

            Facade.CreateRequest(request);
        }
        public void RemoveRequest(string orderNumber)
        {
            Facade.DeleteRequest(orderNumber); // Метод сам найдёт и удалит по номеру
        }
        public List<Repair_orders> LoadClientRequest(int clientId) // Загрузка всех заявок клиента
        {
            return Facade.ReadRequest(clientId);
        }

        // Методы для создания заявки
        public List<Machines> LoadMachines() => Facade.ReadMachines();
        public List<Repairs> LoadRepairs() => Facade.ReadRepairs();

        // Генерация номера заявки
        public string GenerateOrderNumber() =>
             $"ORD{DateTime.Now.ToString("MM.dd-HH:mm:ss")}";

        public void UpdateRequest(Repair_orders request)
        {
            Facade.UpdateRequest(request);
        }
    }
}
    

