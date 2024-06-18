using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator.Games
{
    public interface IGamesRepository
    {
        Task<List<GameModel>> GetClientGames(Guid idClient);
        Task<GameModel> GetGame(Guid idGame);
    }
}
