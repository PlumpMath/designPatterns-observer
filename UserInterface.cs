using System;

namespace observer
{
    public class UserInterface : IObserver
    {
        public void Update(ISubject sender)
        {
            // Console.WriteLine("Hey user, look at this.");
            Console.WriteLine("Hey user, look at {0}.", sender.Data.ToUpper());
        }
    }
}