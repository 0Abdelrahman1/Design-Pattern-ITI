namespace Entities
{
    public class Game
    {
        public Team FirstTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Team SecondTeam { get; set; } = new Team() { Players = [new(), new(), new()] };
        public Ball FootBall { get; set; } = new Ball();
        public Referee FirstReferee { get; set; } = new Referee();
        public Referee SecondReferee { get; set; } = new Referee();
        public Referee ThirdReferee { get; set; } = new Referee();

        public Game()
        {
            FirstReferee.Ball = FootBall;
            SecondReferee.Ball = FootBall;
            ThirdReferee.Ball = FootBall;

            FootBall.Attach(FirstReferee);
            FootBall.Attach(SecondReferee);
            FootBall.Attach(ThirdReferee);

            foreach (Player p in FirstTeam.Players)
            {
                p.Ball = FootBall;
                FootBall.Attach(p);
            }
            foreach (Player p in SecondTeam.Players)
            {
                p.Ball = FootBall;
                FootBall.Attach(p);
            }
        }

    }
}