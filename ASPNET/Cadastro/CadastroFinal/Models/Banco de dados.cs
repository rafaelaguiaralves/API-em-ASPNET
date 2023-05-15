using Microsoft.EntityFrameworkCore;

namespace CadastroFinal.Models
{
    public class Bancodedados : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CadastroFinal;Integrated Security=True");
        }


    }    
}
