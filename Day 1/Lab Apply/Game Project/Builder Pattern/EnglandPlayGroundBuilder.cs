namespace Entities
{
    public class EnglandPlayGroundBuilder : PlayGroundBuilder
    {
        public EnglandPlayGroundBuilder() : base(PlayGroundType.England) {}

        public override PlayGroundBuilder BuildAudience(Audience audience)
        {
            audience.Name += "[England]";
            PlayGround[ContentType.Audience] = audience;
            return this;
        }

        public override PlayGroundBuilder BuildGallary(Gallary gallary)
        {
            gallary.Name += "[England]";
            PlayGround[ContentType.Gallary] = gallary;
            return this;
        }

        public override PlayGroundBuilder BuildSurface(Surface surface)
        {
            surface.Name += "[England]";
            PlayGround[ContentType.Surface] = surface;
            return this;
        }
    }
}