
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisPartCore.Models
{
    public class Palmares
    {
        [Key]
        public int IdMatch { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public Joueur IdJoueur1 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public Joueur IdJoueur2 { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Score { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int EtatJoueur1 { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int EtatJoueur2 { get; set; }

    }
}
