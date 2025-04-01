using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPlayers.MongoDB
{
    public static class SeedData
    {
        public static void SeedChessPlayers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChessPlayer>().HasData(
                new ChessPlayer()
                {
                    Id = 1,
                    Name = "Jose Raul Capablanca",
                    Title = "GM",
                    Rating = 2500
                },
                new ChessPlayer()
                {
                    Id = 2,
                    Name = "Aleksander Alekhine",
                    Title = "GM",
                    Rating = 2510
                }
            );
        }
    }
}
