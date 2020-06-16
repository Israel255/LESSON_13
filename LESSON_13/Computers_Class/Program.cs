using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer lenovo = new Computer()
            {
                model = "yoga",
                numberOfProcessors = 1,
                price = 3579,
                screenSize = 14
            };
            lenovo.tellMeThePrice();
            lenovo.tellTheScreenSize();
            lenovo.turnOn();
            lenovo.turnOff();
            lenovo.addProcessor();
            Console.WriteLine(lenovo);
            Console.WriteLine();

            Computer dell = new Computer()
            {
                model = "inspiron",
                numberOfProcessors = 1,
                price = 3790,
                screenSize = 15.6f
            };
            dell.tellMeThePrice();
            dell.tellTheScreenSize();
            dell.turnOn();
            dell.turnOff();
            dell.addProcessor();
            Console.WriteLine(dell);
            Console.WriteLine();

            Computer apple = new Computer()
            {
                model = "macbook pro",
                numberOfProcessors = 1,
                price = 17105,
                screenSize = 16
            };
            apple.tellMeThePrice();
            apple.tellTheScreenSize();
            apple.turnOn();
            apple.turnOff();
            apple.addProcessor();
            Console.WriteLine(apple);
            Console.WriteLine();


        }
    }
}
