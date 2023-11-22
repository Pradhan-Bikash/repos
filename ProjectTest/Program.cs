using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class ComponetBase
    {
        public double Cost;
        public double Weight;
        public double Area;
    }
    public class Room
    {
        Computer com1 = new Computer();
        Computer com2 = new Computer();
        Computer com3 = new Computer();
        List<Computer> comp = new List<Computer>();
        //table
        Table table1 = new Table();
        Table table2 = new Table();
        List<Table> tables = new List<Table>();
        //tv
        TV tv1 = new TV();
        List<TV> tv = new List<TV>();
        //Lights
        Light light1 = new Light();
        List<Light> lights=new List<Light>();
        public Room()
        {
            com1.Type = "PC1";
            com1.Ram = 4;
            com1.Memory ="1tb";
            com1.Processor = "I5";
            com1.Cost = 5000;
            com1.Weight = 5.6;
            com1.Area = 7.8;
            
            com2.Type = "PC2";
            com2.Ram = 16;
            com2.Memory = "500GB";
            com2.Processor = "I3";
            com2.Cost = 5000;
            com2.Weight = 5.6;
            com2.Area = 7.8;

            com3.Type = "PC3";
            com3.Ram = 8;
            com3.Memory = "240GB";
            com3.Processor ="I7";
            com3.Type = "PC";
            com3.Cost = 5000;
            com3.Weight = 5.6;
            com3.Area = 7.8;

            comp.Add(com1);
            comp.Add(com2);
            comp.Add(com3);
            //Table
            table1.Type = "Study Table";
            table1.Cost = 5000;
            table1.Weight = 5.6;
            table1.Area = 7.8;
            table2.Type = "Wood";
            table2.Cost = 5000;
            table2.Weight = 5.6;
            table2.Area = 7.8;

            tables.Add(table1);
            tables.Add(table2);
            table1.LaptopInformation("I5", 8, "1tb", 15.6f);

            //TV
            tv1.Type = "Android";
            tv1.Quantity = 1;
            tv1.Price = 25000;
            tv1.DisplaySize = 42;
            tv1.Cost = 5000;
            tv1.Weight = 5.6;
            tv1.Area = 7.8;
            tv.Add(tv1);

            //Lights
            light1.Type = "Blub";
            light1.Brand = "Philips";
            light1.Price = 300;
            light1.Cost = 5000;
            light1.Weight = 9.6;
            light1.Area = 7.8;
            lights.Add(light1);
        }
        public void showAll()
        {
            foreach (var c in comp)
            {
                c.show();
            }
            foreach (var t in tables)
            {
                t.show();

            }
            foreach(var TvInformation in tv)
            {
                TvInformation.show();
            }
            foreach(var l in lights)
            {
                l.show();
            }
        }
        public double showInformation(string infoType)
        {
             double totalCost=0;
           
            foreach (var c in comp)
            {
                if (infoType == "Cost")
                {
                    totalCost += c.Cost;
                }
                else if(infoType == "Weight")
                {
                    totalCost += c.Weight;
                }
                else if (infoType == "Area")
                {
                    totalCost += c.Area;
                }   
            }
            foreach (var t in tables)
            {
                
                if (infoType == "Cost")
                {
                    totalCost += t.Cost;
                }
                else if (infoType == "Weight")
                {
                    totalCost += t.Weight;
                }
                else if (infoType == "Area")
                {
                    totalCost += t.Area;
                }

            }
            foreach (var TvInformation in tv)
            {
                
                if (infoType == "Cost")
                {
                    totalCost += TvInformation.Cost;
                }
                else if (infoType == "Weight")
                {
                    totalCost += TvInformation.Weight;
                }
                else if (infoType == "Area")
                {
                    totalCost += TvInformation.Area;
                }
            }
            foreach (var l in lights)
            {
                if (infoType == "Cost")
                {
                    totalCost += l.Cost;
                }
                else if (infoType == "Weight")
                {
                    totalCost += l.Weight;
                }
                else if (infoType == "Area")
                {
                    totalCost += l.Area;
                }

            }
            return totalCost;
        }

        public double TotalCost()
        {
            return showInformation("Cost");
        }
        public double TotalWeight()
        {
            return showInformation("Weight");
        }
        public double TotalArea()
        {
            return showInformation("Area");
        }



    }
    public class Program
    {
        static void Main(string[] args)
        {
            Room r = new Room();
            r.showAll();
            Console.WriteLine(r.TotalCost());
            Console.WriteLine(r.TotalWeight());
            Console.WriteLine(r.TotalArea());


            Console.ReadLine();
            


        }
    }
}





