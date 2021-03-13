using System;

namespace Ladybug.Models.NameBug
{
    public class NameBugRequest
    {
        public int id { get; set; }
        public string namebug { get; set; }
        public int? severity_id { get; set; }
        public string findername { get; set; }
        public int? status_id { get; set; }
        public DateTime? start_date { get; set; }
        public bool is_delete { get; set; }
    }
}
