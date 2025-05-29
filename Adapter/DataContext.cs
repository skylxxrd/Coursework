// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PIS_InfoSystem.Model;

namespace PIS_InfoSystem.Adapter
{
    internal class DataContext : DbContext, IRepository
    {
        public DbSet<User> users { get; set; }
        public DbSet<Repair_orders> repair_orders { get; set; }
        public DbSet<Repairs> repairs { get; set; }
        public DbSet<Machines> machines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pis;Username=postgres;Password=postgres");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public void Save()
        {
            SaveChanges();
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>().Remove(entity);
        }
        public void SaveChanges()
        {
            base.SaveChanges();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            Set<TEntity>().Add(entity);
        }
    }
}
