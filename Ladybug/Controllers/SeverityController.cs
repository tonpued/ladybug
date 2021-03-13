using Ladybug.Models.Severity;
using Ladybug.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ladybug.Controllers
{
    public class SeverityController
    {
        private readonly ISeverityRepository severityRepository;
        public SeverityController(ISeverityRepository severityRepository)
        {
            this.severityRepository = severityRepository;
        }

        [HttpGet("api/severity")]
        public List<SeverityModels> getAll()
        {
            return this.severityRepository.getAll();
        }

        [HttpGet("api/severity/{id}")]
        public SeverityModels getById(int id)
        {
            return this.severityRepository.getById(id);
        }
    }
}
