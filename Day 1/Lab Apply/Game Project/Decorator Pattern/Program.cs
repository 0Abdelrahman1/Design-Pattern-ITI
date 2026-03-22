namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game g = new();
            g.Team.Players.AddRange(
                [new Forward(new FieldPlayer()),
                new MidFielder(new FieldPlayer()),
                new Defender(new FieldPlayer()),
                new GoalKeeper(),
                new Forward(new MidFielder(new Defender(new FieldPlayer())))
                ]);
            Forward fp = (Forward)g.Team.Players[0];
            MidFielder mp = (MidFielder)g.Team.Players[1];
            Defender dp = (Defender)g.Team.Players[2];
            GoalKeeper gk = (GoalKeeper)g.Team.Players[3];
            Player p = g.Team.Players[4];

            fp.PassBall();   
            fp.ShootGoal();
            Console.WriteLine();
            Console.WriteLine();
            
            mp.PassBall();
            mp.Dribble();
            Console.WriteLine();
            Console.WriteLine();

            dp.PassBall();
            dp.Defend();
            Console.WriteLine();
            Console.WriteLine();

            gk.PassBall();
            Console.WriteLine();
            Console.WriteLine();

            p.PassBall();
            Console.WriteLine();
            ((Forward)p).PassBall();
            ((Forward)p).ShootGoal();
            Console.WriteLine();
            ((MidFielder)((PlayerRole)p).Player).PassBall();
            ((MidFielder)((PlayerRole)p).Player).Dribble();
            Console.WriteLine();
            ((Defender)((PlayerRole)((PlayerRole)p).Player).Player).PassBall();
            ((Defender)((PlayerRole)((PlayerRole)p).Player).Player).Defend();
            Console.WriteLine();
        }
    }
}
