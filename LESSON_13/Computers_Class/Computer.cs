using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers_Class
{
    [DebuggerDisplay("model: {model} price: {(price/3.67)}")]
    public class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public int tellMeThePrice()
        {
            Console.WriteLine("The computer price is: " + price);
            return price;
        }
        public float tellTheScreenSize()
        {
            Console.WriteLine("The computer screen size is: " + screenSize);
            return screenSize;
        }
        public void turnOn()
        {
            if (isTurnOn == true)
            {
                Console.WriteLine("the " + model + " computer is on alredy");
            }
            else
            {
                Console.WriteLine("Turning on the " + model + " computer");
                isTurnOn = true;
            }
        }
        public void turnOff()
        {
            if (isTurnOn == false)
            {
                Console.WriteLine("the " + model + " computer is off alredy");
            }
            else
            {
                Console.WriteLine("Turning off the " + model + " comuter");
                isTurnOn = false;
            }
        }
        public void addProcessor()
        {
            numberOfProcessors++;
        }
        public override string ToString()
        {
            return "Computer Model: " + model + " Computer price: " + price + " Number Of Precessors: " + numberOfProcessors + " Screen size: " + screenSize; 
        }
    }
}
