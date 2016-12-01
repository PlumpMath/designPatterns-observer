using System;

namespace observer
{
    public class Logger : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine("Writing down {0}.", sender.Data.ToUpper());
        }
    }
}