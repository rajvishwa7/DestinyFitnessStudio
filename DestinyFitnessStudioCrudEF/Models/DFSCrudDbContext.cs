using System.Data.Entity;

namespace DestinyFitnessStudioCrudEF.Models
{
    public class DFSCrudDbContext : DbContext
    {
        public DFSCrudDbContext() : base("DFSConnection")
        {

        }

        public DbSet<Membership> Memberships { get; set; }
    }
}