using Infastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(t => t.HomeTeam)
                .WithMany(m => m.HomeMatches)
                .HasForeignKey(t => t.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Match>()
                .HasOne(t => t.AwayTeam)
                .WithMany(m => m.AwayMatches)
                .HasForeignKey(t => t.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
