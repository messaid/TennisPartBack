
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisPartCore.Models
{
    public class Classements
    {
        [Key]
        public int IdClassement { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string Classement { get; set; }
    }
}
