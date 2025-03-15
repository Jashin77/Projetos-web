using Microsoft.EntityFrameworkCore;
using QuizCarros.Models;
namespace QuizCarros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Perguntas> Perguntas { get; set; }
    }
}
