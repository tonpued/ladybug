using Ladybug.Models;
using Ladybug.Models.NameBug;
using Ladybug.Models.Severity;
using Ladybug.Models.Status;
using Microsoft.EntityFrameworkCore;

namespace Ladybug.Data
{
    public class LadybugContext : DbContext
    {
        public LadybugContext(DbContextOptions<LadybugContext> options) : base(options)
        {
        }

        public DbSet<HealthCheckModel> HealthCheck { get; set; }
        public DbSet<NameBugModel> NameBug { get; set; }
        public DbSet<SeverityModels> Severity { get; set; }
        public DbSet<StatusModels> Status { get; set; }

    }
}
