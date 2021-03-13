using Ladybug.Models.Status;
using Ladybug.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ladybug.Controllers
{
    public class StatusController
    {
        private readonly IStatusRepository statusRepository;
        public StatusController(IStatusRepository statusRepository)
        {
            this.statusRepository = statusRepository;
        }

        [HttpGet("api/status")]
        public List<StatusModels> getAll()
        {
            return this.statusRepository.getAll();
        }

        [HttpGet("api/status/{id}")]
        public StatusModels getById(int id)
        {
            return this.statusRepository.getById(id);
        }
    }
}
