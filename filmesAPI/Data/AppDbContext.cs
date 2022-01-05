using filmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace filmesAPI.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }


        //public AppDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Cinema>(Cinema => Cinema.EnderecoId);

            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(gerente => gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId);
                //.IsRequired(false) // Permitir a criação de um cinema sem um gerente
                //.OnDelete(DeleteBehavior.Restrict) // Impedir que um gerente seja deletado caso possua um cinema

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Filme)
                .WithMany(filme => filme.Sessoes)
                .HasForeignKey(sessao => sessao.FilmeId);

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Cinema)
                .WithMany(cinema => cinema.Sessoes)
                .HasForeignKey(sessao => sessao.CinemaId);

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseMySQL(_configuration.GetConnectionString("FilmeConnection"));

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseLazyLoadingProxies().UseMySQL("server=127.0.0.1;database=filmeDb;user=root;password=root");



    }
}
