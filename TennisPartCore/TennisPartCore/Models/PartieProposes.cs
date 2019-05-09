using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisPartCore.Models
{
    public class PartieProposes
    {
        [Key]
        public int IdPartie { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public Joueur IdJoueurProposant { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public Classements IdClassementMin { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public Classements IdClassementMax { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime HeurePartie { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LocalisationMatch { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Participation { get; set; }
    }
}
