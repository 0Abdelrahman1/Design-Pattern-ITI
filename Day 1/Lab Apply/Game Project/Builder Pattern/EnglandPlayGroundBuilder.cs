namespace Entities
{
    public class EnglandPlayGroundBuilder : PlayGroundBuilder
    {
        public EnglandPlayGroundBuilder() : base(PlayGroundType.England) {}

        public override void BuildAudience(Audience audience)
        {
            audience.Name += "[England]";
            PlayGround[ContentType.Audience] = audience;
        }

        public override void BuildGallary(Gallary gallary)
        {
            gallary.Name += "[England]";
            PlayGround[ContentType.Gallary] = gallary;
        }

        public override void BuildSurface(Surface surface)
        {
            surface.Name += "[England]";
            PlayGround[ContentType.Surface] = surface;
        }
    }
}