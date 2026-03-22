namespace Entities
{
    public class PlayGround
    {
        private PlayGroundType _type;
        private Dictionary<ContentType, PlayGroundContent> _contents = new();

        public PlayGround(PlayGroundType type)
        {
            _type = type;
        }

        public PlayGroundContent this[ContentType key]
        {
            get { return _contents[key]; }
            set { _contents[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine($"Play Ground Type:{_type}");
            foreach (var content in _contents)
                Console.WriteLine($"\t{content.Key}: {content.Value}");
        }
    }
}