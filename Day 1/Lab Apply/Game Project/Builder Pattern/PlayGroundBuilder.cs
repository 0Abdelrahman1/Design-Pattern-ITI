namespace Entities
{
    public abstract class PlayGroundBuilder
    {
        public PlayGround PlayGround { get; private set; }

        public PlayGroundBuilder(PlayGroundType playGroundType)
        {
            PlayGround = new(playGroundType);
        }
        public abstract void BuildGallary(Gallary gallary);
        public abstract void BuildSurface(Surface surface);
        public abstract void BuildAudience(Audience audience);
    }
}