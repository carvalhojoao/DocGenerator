namespace DocGenerator.Games.Data
{
    public class GamesRepository : IGamesRepository
    {
        private List<GameModel> _listOfGames;
        public GamesRepository()
        {
            _listOfGames = new List<GameModel>
            {
                new GameModel
                {
                    IdClient = new Guid("12345678-1234-1234-1234-1234567890AB"),
                    IdGame = new Guid("f4bdc0f1-14f0-4b07-a7f2-97d78384b37a"),
                    Name = "Ghost of Tsushima",
                    Type = "Action",
                    Size = 1000,
                    Price = 50
                },
                new GameModel
                {
                    IdClient = new Guid("12345678-1234-1234-1234-1234567890AB"),
                    IdGame = new Guid("8a3eb11e-ea5a-4b64-9e08-d4c48c6b26b6"),
                    Name = "Spider Man",
                    Type = "Action",
                    Size = 1500,
                    Price = 100
                },
                 new GameModel
                {
                    IdClient = new Guid("12345678-1234-1234-1234-1234567890AB"),
                    IdGame = new Guid("5d3a7d7f-2fa7-45c3-9aaf-712e12b2099d"),
                    Name = "The Last of Us",
                    Type = "thriller",
                    Size = 2000,
                    Price = 70
                }
            };
        }

        public async Task<List<GameModel>> GetClientGames(Guid idClient)
        {
            return _listOfGames.Where(x => x.IdClient.Equals(idClient)).ToList();
        }

        public async Task<GameModel> GetGame(Guid idGame)
        {
            return _listOfGames.FirstOrDefault(x => x.IdClient.Equals(idGame));
        }
    }
}
