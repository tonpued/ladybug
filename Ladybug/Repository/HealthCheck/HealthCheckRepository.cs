using Ladybug.Data;
using Ladybug.Models;
using System.Linq;

namespace Ladybug.Repository
{
    public class HealthCheckRepository : IHealthCheckRepository
    {
        private readonly LadybugContext context;

        public HealthCheckRepository(LadybugContext context)
        {
            this.context = context;
        }

        public HealthCheckModel GetHealthCheck()
        {
            return this.context.HealthCheck.Where(a => a.id == 1).FirstOrDefault();
        }
    }
}
