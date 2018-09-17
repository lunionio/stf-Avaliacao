using Microsoft.EntityFrameworkCore;

namespace Avaliacao.Repositorio
{
    public class Contexto: DbContext
    {
        public DbSet<Avaliacao.Dominio.Avaliacao> Avaliacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=34.226.175.244;Initial Catalog=Staffpro_Profissionais;Persist Security Info=True;User ID=sa;Password=StaffPro@123;");
        }
    }
}
