using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public abstract class Subject
    {
        private readonly List<IObserver> _observers;

        protected Subject()
        {
            _observers = new List<IObserver>();
        }


        public virtual void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public virtual void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public virtual void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}