using Microsoft.EntityFrameworkCore;

namespace FutebolApi
{
    public class appDbContext : DbContext
    {
        public appDbContext (DbContextOptions<appDbContext> options) : base(options){}

        public DbSet<Time> Times => Set<Time>();
    }
}