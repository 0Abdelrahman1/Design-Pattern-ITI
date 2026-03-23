namespace Entities
{
    public abstract class PlayGroundBuilder
    {
        public PlayGround PlayGround { get; private set; }

        public PlayGroundBuilder(PlayGroundType playGroundType)
        {
            PlayGround = new(playGroundType);
        }
        public abstract PlayGroundBuilder BuildGallary(Gallary gallary);
        public abstract PlayGroundBuilder BuildSurface(Surface surface);
        public abstract PlayGroundBuilder BuildAudience(Audience audience);
    }
}