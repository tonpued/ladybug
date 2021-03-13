using Ladybug.Models.Severity;
using System.Collections.Generic;

namespace Ladybug.Repository
{
    public interface ISeverityRepository
    {
        List<SeverityModels> getAll();
        SeverityModels getById(int id);
    }
}
