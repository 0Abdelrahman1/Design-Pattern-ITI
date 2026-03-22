namespace Entities
{
    internal class ItalyPlayGroundBuilder : PlayGroundBuilder
    {
        public ItalyPlayGroundBuilder() : base(PlayGroundType.Italy) {}
        public override void BuildAudience(Audience audience)
        {
            audience.Name += "[Italy]";
            PlayGround[ContentType.Audience] = audience;
        }
        public override void BuildGallary(Gallary gallary)
        {
            gallary.Name += "[Italy]";
            PlayGround[ContentType.Gallary] = gallary;
        }
        public override void BuildSurface(Surface surface)
        {
            surface.Name += "[Italy]";
            PlayGround[ContentType.Surface] = surface;
        }
    }
}