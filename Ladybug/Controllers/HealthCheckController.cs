using Ladybug.Models;
using Ladybug.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Ladybug.Controllers
{
    public class HealthCheckController
    {
        private readonly IHealthCheckRepository HealthCheckRepository;
        public HealthCheckController(IHealthCheckRepository HealthCheckRepository)
        {
            this.HealthCheckRepository = HealthCheckRepository;
        }

        [HttpGet("/healthcheck")]
        public HealthCheckModel GetHealthCheck()
        {
            return this.HealthCheckRepository.GetHealthCheck();
        }

    }
}
