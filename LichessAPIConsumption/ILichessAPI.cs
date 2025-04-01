using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessAPIConsumption
{
    public interface ILichessAPI
    {
        [Get("/player")]
        Task<Ranking> GetTop10PlayersAsync();
    }
}
