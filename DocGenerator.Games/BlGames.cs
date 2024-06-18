using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator.Games
{
    public class BlGames
    {
        private IGamesRepository _gamesRepository;
        public BlGames(IGamesRepository repository)
        {
            _gamesRepository = repository;
        }
        public async Task<List<GameModel>> GetClientGames(Guid idClient)
        {
            return await _gamesRepository.GetClientGames(idClient);
        }

        public async Task<GameModel> GetGame(Guid idGame)
        {
            return await _gamesRepository.GetGame(idGame);
        }
    }
}
