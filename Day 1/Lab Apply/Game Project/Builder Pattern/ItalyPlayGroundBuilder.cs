namespace Entities
{
    public class ItalyPlayGroundBuilder : PlayGroundBuilder
    {
        public ItalyPlayGroundBuilder() : base(PlayGroundType.Italy) {}
        public override PlayGroundBuilder BuildAudience(Audience audience)
        {
            audience.Name += "[Italy]";
            PlayGround[ContentType.Audience] = audience;
            return this;
        }
        public override PlayGroundBuilder BuildGallary(Gallary gallary)
        {
            gallary.Name += "[Italy]";
            PlayGround[ContentType.Gallary] = gallary;
            return this;
        }
        public override PlayGroundBuilder BuildSurface(Surface surface)
        {
            surface.Name += "[Italy]";
            PlayGround[ContentType.Surface] = surface;
            return this;
        }
    }
}