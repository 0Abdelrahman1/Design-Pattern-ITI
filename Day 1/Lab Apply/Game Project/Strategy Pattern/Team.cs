namespace Entities
{
    public class Team
    {
        public TeamStrategy Strategy { get; set; }

        public void PlayGame()
        {
            Console.Write("We Are ");
            Strategy.Play();
        }
    }
}