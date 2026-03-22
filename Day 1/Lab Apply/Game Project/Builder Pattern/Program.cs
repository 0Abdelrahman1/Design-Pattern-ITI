namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();

            g.ConstructPlayGround(new EnglandPlayGroundBuilder());
            g.ShowPlayGround();
            g.ConstructPlayGround(new ItalyPlayGroundBuilder());
            g.ShowPlayGround();
            
        }
    }
}
