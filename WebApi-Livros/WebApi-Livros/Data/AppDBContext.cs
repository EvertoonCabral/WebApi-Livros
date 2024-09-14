using Microsoft.EntityFrameworkCore;
using WebApi_Livros.Models;

namespace WebApi_Livros.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<AutorModel> Livros{ get; set; } 


    }
}
