using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ladybug.Models.Severity
{
    [Table("severity", Schema = "keepbug")]
    public class SeverityModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }
        [Column("severity_name")]
        public string severity_name { get; set; }

    }
}
