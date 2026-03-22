namespace Entities
{
    public class Player
    {
        public void BallPositionChangedNotification(object sender, EventArgs e)
        {
            Console.WriteLine("Player Notified!");
        }
    }
}