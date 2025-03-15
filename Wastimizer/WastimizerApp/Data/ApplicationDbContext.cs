namespace WastimizerApp.Data;
public class WastimizerDbContext : IdentityDbContext
{
    public WastimizerDbContext(DbContextOptions<WastimizerDbContext> options)
        : base(options)
    {
    }

    private DbSet<Company> Companies { get; set; }
    private DbSet<CurrentStatusType> CurrentStatusTypes { get; set; }
    private DbSet<DestinySite> DestinySites { get; set; }
    private DbSet<ProductionSite> ProductionSites { get; set; }
    private DbSet<RecoverOperation> RecoverOperations { get; set; }
    private DbSet<Transporter> Transporters { get; set; }
    private DbSet<Vehicle> Vehicles { get; set; }
    private DbSet<WasteCollection> WasteCollections { get; set; }
    private DbSet<WasteType> WasteTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Configuration of the Company entity
        modelBuilder.Entity<Company>().Property(c => c.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<Company>().Property(c => c.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<Company>().Property(c => c.ActiveSince).IsRequired().HasColumnType("datetime2(0)");
        modelBuilder.Entity<Company>().Property(c => c.FiscalNumber).IsRequired().HasColumnType("int");
        modelBuilder.Entity<Company>().HasIndex(c => c.FiscalNumber).IsUnique();
        modelBuilder.Entity<Company>().Property(c => c.Email).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<Company>().HasIndex(c => c.Email).IsUnique();
        modelBuilder.Entity<Company>().Property(c => c.ActiveSince).IsRequired().HasColumnType("datetime2(0)");

        //Configuration of CurrentStatusType entity
        modelBuilder.Entity<CurrentStatusType>().Property(c => c.Description).IsRequired().HasColumnType("nvarchar(20)");
        modelBuilder.Entity<CurrentStatusType>().HasIndex(c => c.Description).IsUnique();

        //Configuration of DestinySite entity
        modelBuilder.Entity<DestinySite>().Property(d => d.Code).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<DestinySite>().Property(d => d.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<DestinySite>().Property(d => d.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<DestinySite>().Property(d => d.FiscalNumber).IsRequired().HasColumnType("int");
        modelBuilder.Entity<DestinySite>().HasIndex(d => d.FiscalNumber).IsUnique();
        modelBuilder.Entity<DestinySite>().Property(d => d.Address).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<DestinySite>().Property(d => d.Location).IsRequired().HasColumnType("nvarchar(25)");
        modelBuilder.Entity<DestinySite>().Property(d => d.PostalCode).IsRequired().HasColumnType("nvarchar(25)");
        modelBuilder.Entity<DestinySite>().Property(d => d.Country).IsRequired().HasColumnType("nvarchar(25)");

        //Configuration of ProductionSite entity
        modelBuilder.Entity<ProductionSite>().Property(p => p.Code).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<ProductionSite>().HasIndex(p => p.Code).IsUnique();
        modelBuilder.Entity<ProductionSite>().Property(p => p.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<ProductionSite>().Property(p => p.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<ProductionSite>().Property(p => p.ActiveSince).IsRequired().HasColumnType("datetime2(0)");

        // Configuration of RecoverOperation entity
        modelBuilder.Entity<RecoverOperation>().Property(r => r.Code).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<RecoverOperation>().HasIndex(r => r.Code).IsUnique();
        modelBuilder.Entity<RecoverOperation>().Property(r => r.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<RecoverOperation>().Property(r => r.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<RecoverOperation>().Property(r => r.Description).HasColumnType("nvarchar(500)");

        // Configuration of Transporter entity
        modelBuilder.Entity<Transporter>().Property(t => t.Code).HasColumnType("nvarchar(50)");
        modelBuilder.Entity<Transporter>().Property(t => t.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<Transporter>().Property(t => t.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<Transporter>().Property(t => t.FiscalNumber).IsRequired().HasColumnType("int");
        modelBuilder.Entity<Transporter>().HasIndex(t => t.FiscalNumber).IsUnique();

        // Configuration of Vehicle entity
        modelBuilder.Entity<Vehicle>().Property(v => v.LicensePlate).IsRequired().HasColumnType("nvarchar(25)");

        // Configuration of WasteCollection entity
        modelBuilder.Entity<WasteCollection>().Property(w => w.Code).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<WasteCollection>().HasIndex(w => w.Code).IsUnique();
        modelBuilder.Entity<WasteCollection>().Property(w => w.Tonnage).IsRequired().HasColumnType("decimal(18,2)");
        modelBuilder.Entity<WasteCollection>().Property(w => w.PickupAt).IsRequired().HasColumnType("datetime");

        //vConfiguration of WasteType entity
        modelBuilder.Entity<WasteType>().Property(w => w.Code).IsRequired().HasColumnType("nvarchar(20)");
        modelBuilder.Entity<WasteType>().HasIndex(w => w.Code).IsUnique();
        modelBuilder.Entity<WasteType>().Property(w => w.ShortDesignation).IsRequired().HasColumnType("nvarchar(50)");
        modelBuilder.Entity<WasteType>().Property(w => w.FullDesignation).IsRequired().HasColumnType("nvarchar(200)");
        modelBuilder.Entity<WasteType>().Property(r => r.Description).HasColumnType("nvarchar(500)");
    }
}