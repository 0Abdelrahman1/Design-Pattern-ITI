namespace Entities
{
    public class Game
    {
        public Team FirstTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Team SecondTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Ball Ball { get; set; } = new Ball();
        public Referee FirstReferee { get; set; } = new Referee();
        public Referee SecondReferee { get; set; } = new Referee();
        public Referee ThirdReferee { get; set; } = new Referee();

        public Game()
        {
            Ball.OnPositionChange += FirstReferee.BallPositionChangedNotification;
            Ball.OnPositionChange += SecondReferee.BallPositionChangedNotification;
            Ball.OnPositionChange += ThirdReferee.BallPositionChangedNotification;

            foreach (Player p in FirstTeam.Players)
                Ball.OnPositionChange += p.BallPositionChangedNotification;
            foreach (Player p in SecondTeam.Players)
                Ball.OnPositionChange += p.BallPositionChangedNotification;
        }

    }
}