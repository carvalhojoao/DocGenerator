using DocGenerator.Games;

namespace DocGenerator.Client
{
    public class ClientModel
    {
        public ClientModel()
        {
            
        }
        public Guid IdClient { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public List<GameModel> ClientGames { get; set; }
    }
}
