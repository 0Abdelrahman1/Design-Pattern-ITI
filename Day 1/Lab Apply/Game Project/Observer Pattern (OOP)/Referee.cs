namespace Entities
{
    public class Referee : IObserver
    {
        public Ball Ball { get; set; }
        public void Update()
        {
            Console.WriteLine($"Referee Notified!");
        }
    }
}