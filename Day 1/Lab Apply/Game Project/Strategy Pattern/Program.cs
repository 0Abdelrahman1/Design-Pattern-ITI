namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game g = new();

            var t = g.Team;
            t.PlayGame();
            t.Strategy = new DefendStrategy();
            t.PlayGame();
        }
    }
}
