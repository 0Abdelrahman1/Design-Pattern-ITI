namespace Entities
{
    public class Team
    {
        public TeamStrategy Strategy
        {
            get;
            set => field = value ?? throw new ArgumentNullException(nameof(value), "Strategy cannot be null");
        } = new DefendStrategy();

        public void PlayGame()
        {
            Console.Write("We Are ");
            Strategy.Play();
        }
    }
}