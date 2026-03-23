namespace Entities
{
    public abstract class SubjectObserved
    {
        private readonly List<IObserver> observers = new();

        protected void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(this);
        }
        public void Attach(IObserver obs) => observers.Add(obs);
        public void Detach(IObserver obs) => observers.Remove(obs);
    }
}