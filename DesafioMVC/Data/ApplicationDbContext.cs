using DesafioMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente>? Clientes { get; set; }
    }
}
