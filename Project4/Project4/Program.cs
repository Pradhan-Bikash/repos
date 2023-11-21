using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class ComponentBase
    {
        public string Name;
        public int Cost;
        public double Weight;
        public double Area;
        
        public void printInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Cost: " + Cost);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Area: " + Area);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture furniture1 = new Furniture();
            furniture1.Name = "table";
            furniture1.Type = "wood";
            furniture1.Cost = 2300;
            furniture1.Weight = 5.0;
            furniture1.Area = 100;
            furniture1.printInformation();
            furniture1.printShow();

            Electronics electronics = new Electronics();
            electronics.Name = "Bulb";
            electronics.Type = "LED";
            electronics.Cost = 200;
            electronics.Weight = 0.3;
            electronics.Area = 50;
            electronics.printInformation();
            electronics.printShow();
            Console.ReadLine();


        }
    }
}
