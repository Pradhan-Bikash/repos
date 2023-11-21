using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class ComponentBase
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public double Area { get; set; }


        public ComponentBase(string name, int weight, int price, double area)
        {
            Name = name; Weight = weight; Price = price; Area = area;
        }
    }
    public class Room
    {
        public List<Furniture> FurnitureList = new List<Furniture>();
        public void AddComponent(Furniture furniture)
        {
            FurnitureList.Add(furniture);
        }
        public List<Electronics> ElectronicsList = new List<Electronics>();
        public void AddComponent(Electronics electronics)
        {
            ElectronicsList.Add(electronics);
        }
         public void showAll()
        {
            foreach (var f in FurnitureList)
            {
                f.show();
            }
        }

    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Room myRoom = new Room();
            myRoom.AddComponent(new Furniture("Table", 4, 3500, 8.4));
            myRoom.AddComponent(new Furniture("chair", 3, 300, 4.8));
            myRoom.AddComponent(new Furniture("Almirha",3, 300, 4.8));
            myRoom.AddComponent(new Furniture("Door",3, 300, 4.8));
            myRoom.AddComponent(new Electronics("Tv",3, 300, 4.8));
            myRoom.AddComponent(new Electronics("Light",3, 300, 4.8));
            myRoom.AddComponent(new Electronics("Computer",3, 300, 4.8));
      
            



            myRoom.showAll();
            Console.ReadLine();
        }
    }
}
