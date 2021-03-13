using Ladybug.BesinessLogic;
using Ladybug.Models.NameBug;
using Ladybug.Models.Page;
using Ladybug.Repository.NameBug;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Ladybug.Controllers
{
    public class NameBugController
    {
        private readonly INameBugRepository NameBugRepository;
        private readonly NameBugBusinessLogic nameBugBusinessLogic;
        public NameBugController(INameBugRepository NameBugRepository, NameBugBusinessLogic nameBugBusinessLogic)
        {
            this.NameBugRepository = NameBugRepository;
            this.nameBugBusinessLogic = nameBugBusinessLogic;
        }

        [HttpGet("api/namebug")]
        public PageResponse<NameBugModel> GetAll([FromQuery] PageRequest pageRequest, [FromQuery] NameBugRequest fillter)
        {
                Expression<Func<NameBugModel, bool>> predicate = this.nameBugBusinessLogic.MapFillterNameBug(fillter);
                IQueryable<NameBugModel> source = this.NameBugRepository.GetAll(predicate).AsQueryable();
                PageResponse<NameBugModel> pageEmployee = PaginatedList<NameBugModel>.Create(source, pageRequest);
                return pageEmployee;
        }

        [HttpGet("api/namebug/{id}")]
        public NameBugModel GetEmployeeById(int id)
        {
            return this.NameBugRepository.GetEmployeeById(id);
        }

        [HttpPost("api/namebug")]
        public NameBugModel CreateEmployee([FromBody] NameBugRequest nameBugRequest)
        {
            NameBugModel nameBugModel = this.nameBugBusinessLogic.MapCreateNameBug(nameBugRequest);
            return this.NameBugRepository.CreateNameBug(nameBugModel);
        }

        [HttpPatch("api/namebug/{id}")]
        public NameBugModel UpdateEmployee(int id, [FromBody] NameBugRequest employeeRequest)
        {
            NameBugModel employeeById = NameBugRepository.GetEmployeeById(id);
            NameBugModel employee = this.nameBugBusinessLogic.MapUpdateNameBug(employeeById, employeeRequest);
            return this.NameBugRepository.UpdateEmployee(employee);
        }

        [HttpDelete("api/namebug/{id}")]
        public bool DeleteEmployee(int id)
        {
            NameBugModel NameBug = NameBugRepository.GetEmployeeById(id);
            return this.NameBugRepository.DeleteEmployee(NameBug);
        }
    }
}
