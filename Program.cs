using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Doer doer = new Doer();

            UserInterface userInterface = new UserInterface();
            Logger logger = new Logger();

            doer.AfterDoSomethingWith += userInterface.AfterDoSomethingWith;
            doer.AfterDoSomethingWith += logger.AfterDoSomethingWith;
            doer.AfterDoMore += logger.AfterDoMore;

            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
        }
    }
}
