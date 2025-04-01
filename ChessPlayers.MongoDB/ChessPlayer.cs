using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPlayers.MongoDB
{
    public class ChessPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
    }
}
