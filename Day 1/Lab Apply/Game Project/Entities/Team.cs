namespace Entities
{
    public class Team
    {
        public List<Player> Players {  get; set; } = new();
        public TeamStrategy Strategy { get; set; }
    }
}