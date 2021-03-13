using Ladybug.Data;
using Ladybug.Models.NameBug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ladybug.Repository.NameBug
{
    public class NameBugRepository : INameBugRepository
    {
        private readonly LadybugContext context;
        public NameBugRepository(LadybugContext context)
        {
            this.context = context;
        }

        public NameBugModel CreateNameBug(NameBugModel nameBugModel)
        {
            if (nameBugModel != null)
            {
                this.context.NameBug.AddRange(nameBugModel);
                this.context.SaveChanges();
            }
            return nameBugModel;
        }

        public List<NameBugModel> GetAll(Expression<Func<NameBugModel, bool>> Predicate)
        {
            return this.context.NameBug.Where(Predicate).ToList();
        }

        public NameBugModel GetEmployeeById(int id)
        {
            NameBugModel NameBug = this.context.NameBug.Where(a => a.id == id).FirstOrDefault();
            if (NameBug == null)
            {
                Console.WriteLine("หาไม่เจอ");
            }
            return NameBug;
        }

        public NameBugModel UpdateEmployee(NameBugModel NameBug)
        {
            this.context.NameBug.Update(NameBug);
            this.context.SaveChanges();
            return NameBug;
        }

        public bool DeleteEmployee(NameBugModel NameBug)
        {
            if (NameBug != null)
            {
                NameBug.is_delete = true;
                this.context.NameBug.Update(NameBug);
                this.context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
