using LichessAPIConsumption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPlayers
{
    public class App
    {
        private readonly ILichessAPI _lichessAPI;

        public App(ILichessAPI lichessAPI)
        {
            _lichessAPI = lichessAPI;
        }

        public async Task RunAsync()
        {
            var data = await _lichessAPI.GetTop10PlayersAsync();

            Console.WriteLine(data.Blitz.First().Username);
        }
    }
}
