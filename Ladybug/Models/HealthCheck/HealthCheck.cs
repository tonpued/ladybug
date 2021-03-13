using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ladybug.Models
{
    [Table("healthcheck", Schema = "keepbug")]
    public class HealthCheckModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }
        [Column("message")]
        public string message { get; set; }
    }
}
