using DocGenerator.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator.Client
{
    public class BlClient
    {
        private IClientRepository _clientRepository;
        private BlGames _blGames;
        public BlClient(IClientRepository clientRepository, BlGames blGames)
        {
            _clientRepository = clientRepository;
            _blGames = blGames;
        }

        public async Task<ClientModel> GetClient(Guid idClient)
        {
            var client = await _clientRepository.GetClient(idClient);
            if (client != null)
            {
                client.ClientGames = await _blGames.GetClientGames(idClient);
            }
            return client;
        }
    }
}
