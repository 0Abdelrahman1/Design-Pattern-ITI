using System.Data;

namespace Entities
{
    public interface IObserver
    {
        void Update(SubjectObserved subject);
    }
}