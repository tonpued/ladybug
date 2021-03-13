using Ladybug.Models.NameBug;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ladybug.Repository.NameBug
{
    public interface INameBugRepository
    {
        List<NameBugModel> GetAll(Expression<Func<NameBugModel, bool>> Predicate);
        NameBugModel CreateNameBug(NameBugModel nameBugModel);
        NameBugModel GetEmployeeById(int id);
        NameBugModel UpdateEmployee(NameBugModel NameBug);
        bool DeleteEmployee(NameBugModel NameBug);
    }
}
