namespace Entities
{
    public abstract class PlayerRole : Player
    {
        public Player Player { get; private set; }

        public PlayerRole(Player player)
        {
            AssignPlayer(player);
        }
        protected string GetRoles(Player current)
        {
            if (current is not PlayerRole) return current.GetType().Name;
            return current.GetType().Name + " " + GetRoles(((PlayerRole)current).Player);
        }
        public override void PassBall()
        {
            //Console.Write($"I am Player With Roles [{GetRoles(this)}] ");
            Console.Write($"{this.GetType().Name} ");
            Player?.PassBall();
        }
        public void AssignPlayer(Player player)
        {
            if (player == null) throw new NullReferenceException("The Player must be of type FieldPlayer or Goalkeeper at the end some how");
            if (player is GoalKeeper) throw new Exception("U can't Add Roles to GoalKeeper");
            this.Player = player;
        }
    }
}