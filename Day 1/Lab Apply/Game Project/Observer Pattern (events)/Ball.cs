namespace Entities
{
    public class Ball
    {
        public event EventHandler OnPositionChange;
        void OnPositionChanged()
        {
            OnPositionChange.Invoke(this, EventArgs.Empty);
        }

        public decimal Position { get; set { field = value; OnPositionChanged(); } }
    }
}