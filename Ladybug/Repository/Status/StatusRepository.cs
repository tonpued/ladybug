using Ladybug.Data;
using Ladybug.Models.Status;
using System.Collections.Generic;
using System.Linq;

namespace Ladybug.Repository
{
    public class StatusRepository : IStatusRepository
    {
        private readonly LadybugContext context;
        public StatusRepository(LadybugContext context)
        {
            this.context = context;
        }
        public List<StatusModels> getAll()
        {
            return this.context.Status.ToList();
        }

        public StatusModels getById(int id)
        {
            return this.context.Status.Where(a => a.id == id).FirstOrDefault();
        }
    }
}
