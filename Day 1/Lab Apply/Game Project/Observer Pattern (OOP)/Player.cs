namespace Entities
{
    public class Player : IObserver
    {
        public Ball Ball { get; set; }
        public void Update()
        {
            Console.WriteLine($"Player Notified!");
        }
    }
}