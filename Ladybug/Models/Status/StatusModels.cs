using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ladybug.Models.Status
{
    [Table("status", Schema = "keepbug")]
    public class StatusModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }
        [Column("status_name")]
        public string status_name { get; set; }
    }
}
