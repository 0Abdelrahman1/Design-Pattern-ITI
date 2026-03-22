using Entities;

namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game football = new();

            football.FootBall.Position = 10.0m;
        }
    }
}
