using Ladybug.Models.Page;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Ladybug.BesinessLogic
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(List<T> items)
        {
            this.AddRange(items);
        }

        public static async Task<PageResponse<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            PaginatedList<T> entities = new PaginatedList<T>(items);
            PageResponse<T> response = new PageResponse<T>();
            response.number = pageNumber;
            response.totalElement = count;
            response.size = pageSize;
            response.entities = entities;
            return response;
        }

        public static PageResponse<T> Create(IQueryable<T> source, PageRequest pageRequest)
        {
            PageResponse<T> response = new PageResponse<T>();
            var count = source.Count();
            var items = source.Skip((pageRequest.number - 1) * pageRequest.size).Take(pageRequest.size).ToList();
            PaginatedList<T> entities = new PaginatedList<T>(items);
            response.number = pageRequest.number;
            response.totalElement = count;
            response.size = pageRequest.size;
            response.entities = entities;
            return response;
        }
    }
}
