namespace Entities
{
    public class Referee : IObserver
    {
        public Ball Ball { get; set; }
        public void Update(SubjectObserved subject)
        {
            if (subject is Ball ball)
                Console.WriteLine($"Referee Notified! Ball position changed to: {ball.Position}");
        }
    }
}