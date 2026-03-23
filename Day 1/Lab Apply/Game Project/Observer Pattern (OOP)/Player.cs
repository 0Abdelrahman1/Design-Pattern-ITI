namespace Entities
{
    public class Player : IObserver
    {
        public Ball Ball { get; set; }
        public void Update(SubjectObserved subject)
        {
            if (subject is Ball ball)
                Console.WriteLine($"Player Notified! Ball position changed to: {ball.Position}");
        }
    }
}