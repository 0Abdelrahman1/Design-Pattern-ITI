using System.Threading.Channels;

namespace Entities
{
    public class Defender : PlayerRole
    {
        public Defender(Player player) : base(player) { }

        public void Defend() => Console.WriteLine($"{GetRoles(this).Replace("Player", "")} Player Defending");
    }
}