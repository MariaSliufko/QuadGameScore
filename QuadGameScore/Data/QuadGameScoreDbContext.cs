using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuadGameScore.Models;
using Microsoft.EntityFrameworkCore.InMemory;

namespace QuadGameScore.Data
{
	public class QuadGameScoreDbContext : DbContext
	{
		public QuadGameScoreDbContext(DbContextOptions<QuadGameScoreDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Score> Scores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>()
                .HasKey(s => new { s.PlayerId, s.GameId }); // Definiera en sammansatt primärnyckel med PlayerId och EventId

            base.OnModelCreating(modelBuilder);
        }
    }
}

