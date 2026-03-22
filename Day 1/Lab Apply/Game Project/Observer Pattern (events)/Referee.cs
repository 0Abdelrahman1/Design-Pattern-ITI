namespace Entities
{
    public class Referee
    {
        public void BallPositionChangedNotification(object sender, EventArgs e)
        {
            Console.WriteLine($"Referee Notified");
        }
    }
}