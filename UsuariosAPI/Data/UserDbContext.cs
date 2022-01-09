using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Models;

namespace UsuariosAPI.Data
{
    public class UserDbContext : IdentityDbContext<CustomIdentityUser, IdentityRole<int>, int>
    {
        //public UserDbContext(DbContextOptions<UserDbContext> opt) : base(opt)
        //{

        //}
        private IConfiguration _config;

        //public UserDbContext(IConfiguration config)
        //{
        //    _config = config;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseMySQL("server=127.0.0.1;database=usuarioDb;user=root;password=root");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            CustomIdentityUser admin = new CustomIdentityUser
            {
                Id = 99999,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            //PasswordHasher<CustomIdentityUser> passwordHasher = new PasswordHasher<CustomIdentityUser>();
            //admin.PasswordHash = passwordHasher.HashPassword(admin, _config.GetValue<string>("admininfo:password"));
            PasswordHasher<CustomIdentityUser> passwordHasher = new PasswordHasher<CustomIdentityUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123!");

            builder.Entity<CustomIdentityUser>().HasData(admin);

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 99999, Name = "admin", NormalizedName = "ADMIN" });

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 99998, Name = "regular", NormalizedName = "REGULAR" });

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 99999, UserId = 99999 });
        }
    }
}
