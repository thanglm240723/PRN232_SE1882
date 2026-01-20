using Microsoft.EntityFrameworkCore;

namespace WebAPI_Models_DTOs.DBContext
{
    public  class CodeFristDbContext : DbContext
    {
        public CodeFristDbContext(DbContextOptions<CodeFristDbContext> options) : base(options)
        {

          

        }
        public DbSet<Models.InstrumentType> InstrumentTypes { get; set; }
        public  DbSet<Models.Player> Players { get; set; }
        public DbSet<Models.PlayerInstrument> PlayerInstruments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Player>()
                .HasMany(p => p.PlayerInstruments)
                .WithOne(pi => pi.Player)
                .HasForeignKey(pi => pi.PlayerId);
            modelBuilder.Seed();
        }

    }
}
