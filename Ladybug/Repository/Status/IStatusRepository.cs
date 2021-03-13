using Ladybug.Models.Status;
using System.Collections.Generic;
namespace Ladybug.Repository
{
    public interface IStatusRepository
    {
        List<StatusModels> getAll();
        StatusModels getById(int id);
    }
}
