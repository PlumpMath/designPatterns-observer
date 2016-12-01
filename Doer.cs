using System;
using System.Collections.Generic;

namespace observer
{
    class Doer : ISubject
    {
        private IList<IObserver> _observers = new List<IObserver>();

        public string Data { get; private set; }

        public void DoSomethingWith(string data)
        {
            // Console.WriteLine("Doing something with {0}.", data);
            Data = data;
            Notify();
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}