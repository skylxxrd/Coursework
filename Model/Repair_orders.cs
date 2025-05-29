// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace PIS_InfoSystem.Model
{
    public class Repair_orders
    {
        public int id { get; set; }
        public string? status { get; set; }
        public string? order_number { get; set; }
        public int repair_id { get; set; }
        public int machine_id { get; set; }
        public int? user_id { get; set; }
        public int? client_id { get; set; }
    }
}
