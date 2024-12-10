using Microsoft.EntityFrameworkCore;
using SiteMark1.Core.Interfaces;
using SiteMark1.Entities;

namespace SiteMark1.Core.Context
{
    public class DBContexto: DbContext, IDBContexto
    {

        public DbSet<Cidade> Cidades { get; set; }
        public List<Cidade> ListarCidades()
        {
            return Cidades.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Data Source=SRVDB03\\MSSQLSERVER_dev,1434;Initial Catalog=sats_producao;User id=user_db_sats;Password=sats@M1lt3c#;TrustServerCertificate=True;Integrated Security=False";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    }
}
