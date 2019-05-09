
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TennisPartCore.Models
{
    public class Joueur : IdentityUser
    {
        [Column(TypeName = "varchar(200)")]
        public string FullName { get; set; }


        [Column(TypeName = "int")]
        public Classements IdClassement { get; set; }


        [Column(TypeName = "int")]
        public int Age { get; set; }


        [Column(TypeName = "varchar(1000)")]
        public string Photo { get; set; }
    }
}
