using Microsoft.EntityFrameworkCore;

namespace PlannerSemanal.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Atividade> Atividades { get; set; }

        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }
    }
}
