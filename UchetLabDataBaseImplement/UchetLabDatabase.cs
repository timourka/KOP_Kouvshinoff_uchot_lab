using Microsoft.EntityFrameworkCore;
using UchetLabDatabaseImplement.Models;

namespace UchetLabDatabaseImplement
{
    internal class UchetLabDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UchetLabDatabaseFull;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
        internal virtual DbSet<Lab> Labs { set; get; }
        internal virtual DbSet<Difficulty> Difficulties { set; get; }
    }
}
