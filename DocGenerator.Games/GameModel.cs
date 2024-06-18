namespace DocGenerator.Games
{
    public class GameModel
    {
        public GameModel()
        {
            
        }
        public Guid IdGame { get; set; }
        public Guid IdClient { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Size { get; set; }
    }
}
