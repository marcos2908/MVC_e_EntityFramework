using Microsoft.EntityFrameworkCore;

namespace MvcEntity.Models
{
    public class MvcEntityContext: DbContext
    {
        public DbSet <Produtos> Produtos { get; set; }

        public DbSet<Categorias> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localDB;mssqllocaldb;Database=mvcentity;Trusted_Connection=True;");
        }
    }
}