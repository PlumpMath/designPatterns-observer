using System;
using System.Collections.Generic;

namespace observer
{
    class Doer : ISubject
    {
        private IList<IObserver> _observers = new List<IObserver>();
        private string _data = string.Empty;

        public void DoSomethingWith(string data)
        {
            _data = data;
            AfterDoSomethingWith(_data);
        }

        public void DoMore(string appendData)
        {
            _data += appendData;
            AfterDoMore(_data, appendData);
        }

        public void AfterDoSomethingWith(string data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.AfterDoSomethingWith(this, data);
            }
        }

        public void AfterDoMore(string completeData, string appendedData)
        {
            foreach (IObserver observer in _observers)
            {
                observer.AfterDoMore(this, completeData, appendedData);
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