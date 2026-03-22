namespace Entities
{
    public class Game
    {
        public Team Team { get; set; } = new Team() { Strategy = new AttackStrategy()};
    }
}