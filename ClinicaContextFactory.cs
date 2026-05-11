using ClinicaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClinicaAPI
{
    public class ClinicaContextFactory : IDesignTimeDbContextFactory<ClinicaContext>
    {
        public ClinicaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicaContext>();
            var connectionString =
                "server=localhost;database=clinica_db;user=root;password=;";
            optionsBuilder.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString));
            return new ClinicaContext(optionsBuilder.Options);
        }
    }
}