using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TennisPartCore.Models
{
    public class TennisPartDbContext : IdentityDbContext
    {

        public TennisPartDbContext(DbContextOptions<TennisPartDbContext> options): base(options)
        {
        }

        public DbSet<Classements> Classements { get; set; }
        public DbSet<Joueur> Joueur { get; set; }
        public DbSet<Palmares> Palmares { get; set; }
        public DbSet<PartieProposes> PartieProposes { get; set; }


    }
}
