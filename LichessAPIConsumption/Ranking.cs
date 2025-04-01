using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessAPIConsumption
{
    public class Ranking
    {
        public List<Player> Bullet { get; set; }
        public List<Player> Blitz { get; set; }
        public List<Player> Rapid { get; set; }
        public List<Player> Classical { get; set; }
    }
}
