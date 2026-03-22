namespace Entities
{
    public class Game
    {
        public PlayGround PlayGround { get; set; } = new PlayGround();
        public Team FirstTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Team SecondTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Ball Ball { get; set; } = new Ball();
        public Referee FirstReferee { get; set; } = new Referee();
        public Referee SecondReferee { get; set; } = new Referee();
        public Referee ThirdReferee { get; set; } = new Referee();
    }
}