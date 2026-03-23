namespace Entities
{
    public class Game
    {

        private PlayGroundBuilder _playGroundBuilder;

        public void ConstructPlayGround(PlayGroundBuilder builder)
        {
            _playGroundBuilder = builder;
            _playGroundBuilder.BuildGallary(new() { Name = "G-" })
                              .BuildSurface(new() { Name = "S-" })
                              .BuildAudience(new() { Name = "A-" });
        }

        public void ShowPlayGround()
        {
            _playGroundBuilder.PlayGround.Show();
        }

    }
}