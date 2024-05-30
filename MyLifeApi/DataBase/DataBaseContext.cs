using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyLifeModel.Domain;

namespace MyLifeApi.DataBase
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Anotacao> Anotacoes { get; set; }

        private string connectionString = "server=localhost;" + 
            "Port=5432;" + 
            "user id=postgres;" +
            "password=123456;" +
            "database=MyLife" +
            "providerName=Npgsql";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
