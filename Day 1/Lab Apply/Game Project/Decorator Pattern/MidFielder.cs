namespace Entities
{
    internal class MidFielder : PlayerRole
    {
        public MidFielder(Player player) : base(player) {}
        public void Dribble() => Console.WriteLine($"{GetRoles(this).Replace("Player", "")} Player Dribbling");
    }
}