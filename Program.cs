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
            UserInterface ui = new UserInterface();
            Logger logger = new Logger();

            doer.Attach(ui);
            doer.Attach(logger);

            doer.DoSomethingWith("my data");

            doer.Detach(ui);
            doer.DoSomethingWith("my data");

            Console.ReadLine();
        }
    }
}
