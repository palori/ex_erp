using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore;//.Extensions;
using ERP.Models;

namespace ERP.Contexts
{
  public class ErpContext : DbContext
  {
    public DbSet<Address> Address { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Supplier> Supplier { get; set; }
    public DbSet<TeamMember> TeamMember { get; set; }

    public ErpContext() {}

    public ErpContext(DbContextOptions<ErpContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string user = "root";
        string password = "root";
        string db = "erp";
        optionsBuilder.UseMySQL($"server=localhost;database={db};user={user};password={password}");

        // ara duplicat, trobar la manera d'utilitzar el mateix string del 'appsettings.json'
        //optionsBuilder.UseMySQL(Configuration.GetConnectionString("DefaultConnection"))
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Address>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Street).IsRequired();
        entity.Property(e => e.Number);
        entity.Property(e => e.Floor_Door);
        entity.Property(e => e.City).IsRequired();
        entity.Property(e => e.PostalCode).IsRequired();
        entity.Property(e => e.Country).IsRequired();
      });

      modelBuilder.Entity<Client>(entity =>
      {
        // Unit
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.PhoneNumber).IsRequired();
        entity.Property(e => e.Email).IsRequired();
        entity.Property(e => e.Registered).IsRequired();
        entity.Property(e => e.LastUpdated).IsRequired();
        // Person
        entity.Property(e => e.Surnames).IsRequired();
        entity.Property(e => e.Gender).IsRequired();
        entity.Property(e => e.Year).IsRequired();
        // Client
        entity.Property(e => e.SendNotifications).IsRequired();
        entity.HasOne(e => e.Address);
      });

      modelBuilder.Entity<Supplier>(entity =>
      {
        // Unit
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.PhoneNumber).IsRequired();
        entity.Property(e => e.Email).IsRequired();
        entity.Property(e => e.Registered).IsRequired();
        entity.Property(e => e.LastUpdated).IsRequired();
        // Supplier
        entity.Property(e => e.Cif).IsRequired();
        entity.HasMany(e => e.Addresses);                 // comprovar si HasMany o HasOne
        // See if needed
        //entity.HasOne(d => d.Publisher)
          //.WithMany(p => p.Books);
      });

      modelBuilder.Entity<TeamMember>(entity =>
      {
        // Unit
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.PhoneNumber).IsRequired();
        entity.Property(e => e.Email).IsRequired();
        entity.Property(e => e.Registered).IsRequired();
        entity.Property(e => e.LastUpdated).IsRequired();
        // Person
        entity.Property(e => e.Surnames).IsRequired();
        entity.Property(e => e.Gender).IsRequired();
        entity.Property(e => e.Year).IsRequired();
        // TeamMember
        entity.Property(e => e.Role).IsRequired();
        entity.Property(e => e.IsAdmin).IsRequired();
        entity.HasOne(e => e.Address);
        entity.Property(e => e.Nif).IsRequired();
        entity.Property(e => e.Salary).IsRequired();

      });
    }
  }
}