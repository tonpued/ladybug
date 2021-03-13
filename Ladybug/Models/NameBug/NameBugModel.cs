using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ladybug.Models.NameBug
{
    [Table("namebug", Schema = "keepbug")]
    public class NameBugModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }
        [Column("namebug")]
        public string namebug { get; set; }
        [Column("severity_id")]
        public int? severity_id { get; set; }
        [Column("findername")]
        public string findername { get; set; }
        [Column("status_id")]
        public int? status_id { get; set; }
        [Column("start_date")]
        public DateTime? start_date { get; set; }
        [Column("is_delete")]
        public bool is_delete { get; set; }
    }
}
