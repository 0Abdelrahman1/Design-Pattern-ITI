namespace Entities
{
    public class Forward : PlayerRole
    {
        public Forward(Player player) : base(player) {}
        public void ShootGoal() => Console.WriteLine($"{GetRoles(this).Replace("Player", "")} Player Shooting");
    }
}