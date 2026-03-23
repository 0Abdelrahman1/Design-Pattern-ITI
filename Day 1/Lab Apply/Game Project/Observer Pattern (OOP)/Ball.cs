using System;

namespace Entities
{
    public class Ball : SubjectObserved
    {
        public decimal Position { get; set { field = value; NotifyObservers(); } }
    }
}