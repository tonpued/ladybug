using Ladybug.Models;

namespace Ladybug.Repository
{
    public interface IHealthCheckRepository
    {
        HealthCheckModel GetHealthCheck();
    }
}
