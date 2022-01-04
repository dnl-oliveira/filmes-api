using filmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace filmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Filme> Filmes { get; set; }
        public FilmeContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL(_configuration.GetConnectionString("FilmeConnection"));



    }
}
