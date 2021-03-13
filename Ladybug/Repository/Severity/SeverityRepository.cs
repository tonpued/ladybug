using Ladybug.Data;
using Ladybug.Models.Severity;
using System.Collections.Generic;
using System.Linq;

namespace Ladybug.Repository
{
    public class SeverityRepository : ISeverityRepository
    {
        private readonly LadybugContext context;
        public SeverityRepository(LadybugContext context)
        {
            this.context = context;
        }
        public List<SeverityModels> getAll()
        {
            return this.context.Severity.ToList();
        }

        public SeverityModels getById(int id)
        {
            return this.context.Severity.Where(a => a.id == id).FirstOrDefault();
        }
    }
}
