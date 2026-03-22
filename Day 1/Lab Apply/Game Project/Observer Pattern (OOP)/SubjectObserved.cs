namespace Entities
{
    public abstract class SubjectObserved
    {
        List<IObserver> observers = new List<IObserver>();

        protected void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }
        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }
    }
}