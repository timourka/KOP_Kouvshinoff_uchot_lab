using Microsoft.EntityFrameworkCore;
using UchetLabDatabaseImplement.Models;

namespace UchetLabDatabaseImplement
{
    public class UchetLabDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UchetLabDatabaseFull;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Lab> Labs { set; get; }
    }
}
