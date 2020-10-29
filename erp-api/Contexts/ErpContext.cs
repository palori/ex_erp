using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore;//.Extensions;
using erp_api.Models;

namespace erp_api.Contexts
{
  public class ErpContext : DbContext
  {
    public DbSet<Address> Address { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Component> Component { get; set; }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<ItemInfo> ItemInfo { get; set; }
    public DbSet<ItemInfoProcessInfo> ItemInfoProcessInfo { get; set; }
    public DbSet<ItemInfoTradingInfo> ItemInfoTradingInfo { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<OrderItemProcessInfo> OrderItemProcessInfo { get; set; }
    public DbSet<Process> Process { get; set; }
    public DbSet<ProcessInfo> ProcessInfo { get; set; }
    public DbSet<Profile> Profile { get; set; }
    public DbSet<Supplier> Supplier { get; set; }
    public DbSet<TeamMember> TeamMember { get; set; }
    public DbSet<TradingInfo> TradingInfo { get; set; }
    public DbSet<WarehouseItem> WarehouseItem { get; set; }

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

      /* modelBuilder.Entity<Address>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.Street).IsRequired();
        entity.Property(e => e.Number);
        entity.Property(e => e.Floor_Door);
        entity.Property(e => e.City).IsRequired();
        entity.Property(e => e.PostalCode).IsRequired();
        entity.Property(e => e.Country).IsRequired();
      });

      modelBuilder.Entity<Address>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
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
        //entity.Property(e => e.Id).IsRequired();
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

      modelBuilder.Entity<Component>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.HasOne(e => e.ItemInfo);
        entity.HasOne(e => e.Product);
        entity.Property(e => e.Units).IsRequired();
      });

      modelBuilder.Entity<ItemInfo>(entity =>
      {
        // Info
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Description).IsRequired();
        // ItemInfo
        entity.Property(e => e.LinkImages);
        entity.Property(e => e.Category).IsRequired();
        // entity.HasMany(e => e.Components);
        // entity.HasMany(e => e.Components);
        entity.HasMany(e => e.Processes);
        entity.HasMany(e => e.BuyInfo);
        entity.HasMany(e => e.SellInfo);
      });

      modelBuilder.Entity<Order>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.Reference);          // Key from either client or supplier. Use HasOne() or Property()
        // entity.HasOne(e => e.Reference);
        entity.HasOne(e => e.Address);
        entity.HasMany(e => e.OrderItems);
        entity.HasMany(e => e.Processes);
        entity.Property(e => e.Priority);
      });

      modelBuilder.Entity<OrderItem>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.HasOne(e => e.ItemInfo);
        entity.HasOne(e => e.Order);
        entity.HasOne(e => e.TradingInfo);
        entity.Property(e => e.Units).IsRequired();
        entity.HasMany(e => e.Processes);
      });

      modelBuilder.Entity<Process>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.HasOne(e => e.ProcessInfo);
        entity.Property(e => e.Started);
        entity.Property(e => e.AssignedTo);
        // entity.HasOne(e => e.AssignedTo);
      });

      modelBuilder.Entity<ProcessInfo>(entity =>
      {
        // Info
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Description).IsRequired();
        // ProcessInfo
        entity.Property(e => e.EstimatedDuration).IsRequired();
      });

      modelBuilder.Entity<Supplier>(entity =>
      {
        // Unit
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
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
        //entity.Property(e => e.Id).IsRequired();
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

      modelBuilder.Entity<TradingInfo>(entity =>
      {
        entity.HasKey(e => e.Id);
        //entity.Property(e => e.Id).IsRequired();
        entity.Property(e => e.Reference);
        // entity.HasOne(e => e.Reference);
        entity.Property(e => e.Price).IsRequired();
        entity.Property(e => e.Iva).IsRequired();
        entity.Property(e => e.MinUnits);
        entity.Property(e => e.PackUnits);
        entity.Property(e => e.DeliveryTime).IsRequired();
      });

      modelBuilder.Entity<Warehouse>(entity =>
      {
        entity.HasNoKey();
        entity.HasOne(e => e.ItemInfo);
        entity.Property(e => e.Units).IsRequired();
        entity.Property(e => e.State).IsRequired();
      }); */
      
    }
  }
}