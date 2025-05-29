// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace PIS_InfoSystem.Model
{
    public class Repairs
    {
        public int id { get; set; }
        public string? repair_name { get; set; }
        public DateTime repair_start_date { get; set; }
        public DateTime repair_end_date { get; set; }
        public decimal repair_cost { get; set; }
    }
}
