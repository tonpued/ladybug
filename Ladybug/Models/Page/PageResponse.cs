using Ladybug.BesinessLogic;
using System;

namespace Ladybug.Models.Page
{
    public class PageResponse<T>
    {
        public int size { get; set; }
        public int number { get; set; }
        public int totalElement { get; set; }
        public int totalPage
        {
            get
            {
                return (int)Math.Ceiling(totalElement / (double)this.size);
            }
        }

        public bool isFirst
        {
            get
            {
                return (this.number == 1);
            }
        }

        public bool isLast
        {
            get
            {
                return (totalPage == this.number);
            }
        }

        public PaginatedList<T> entities { get; set; }
    }
}
