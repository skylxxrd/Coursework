// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using Microsoft.EntityFrameworkCore;
using PIS_InfoSystem.Model;

namespace PIS_InfoSystem.Adapter
{
    public interface IRepository
    {
        DbSet<User> users { get; set; }
        DbSet<Repair_orders> repair_orders { get; set; }
        DbSet<Repairs> repairs { get; set; }
        DbSet<Machines> machines { get; set; }


        void Add<TEntity>(TEntity entity) where TEntity : class;
        void SaveChanges();
        void Remove<TEntity>(TEntity entity) where TEntity : class;
    }
}
