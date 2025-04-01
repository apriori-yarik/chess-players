using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPlayers.MongoDB
{
    public class MongoDbContext : DbContext
    {
        public MongoDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<ChessPlayer> ChessPlayers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChessPlayer>().ToCollection("chess-players");
            modelBuilder.SeedChessPlayers();
        }
    }
}
