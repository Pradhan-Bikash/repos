using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Table : ComponetBase
    {
        public Laptop laptop;
        public string Type;
        //public int Quantity;
        //public int Price;
        Laptop lappy = new Laptop();
        List<Laptop> lap = new List<Laptop>();
        public void LaptopInformation(string Processor, int Ram, string Storage, float DisplaySize)
        {
            this.lappy = new Laptop();
            lappy.Processor = "I5";
            lappy.Ram = 8;
            lappy.Storage = "1TB";
            lappy.DisplaySize = 16.5f;
            lappy.Cost = 5000;
            lappy.Weight = 5.6;
            lappy.Area = 7.8;
            lap.Add(lappy);

        }
        public void show()
        {
            foreach (var lp in lap)
            {
                lp.show();
            }
            Console.WriteLine("Quantity " + Type);
        }
       /* public double showInformation(string infoType)
        {
            double totalCost = 0;

            foreach (var lp in lap)
            {
                if (infoType == "Cost")
                {
                    totalCost += lp.Cost;
                }
                else if (infoType == "Weight")
                {
                    totalCost += lp.Weight;
                }
                else if (infoType == "Area")
                {
                    totalCost += lp.Area;
                }
            }
        }*/
    }
}
