using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class ComponentBase
    {
        public int Cost { get; set; }
        public int Weight { get; set; }
        public int Area { get; set; }

        public ComponentBase(int cost, int weight, int area)
        {
            Cost = cost;
            Weight = weight;
            Area = area;
        }
    }

    // Room class with methods to find total weight, cost, and area
    class Room
    {
        private List<ComponentBase> components;

        public Room()
        {
            components = new List<ComponentBase>();
        }

        public void AddComponent(ComponentBase component)
        {
            components.Add(component);
        }

        public int TotalCost()
        {
            return components.Sum(component => component.Cost);
        }

        public int TotalWeight()
        {
            return components.Sum(component => component.Weight);
        }

        public int TotalArea()
        {
            return components.Sum(component => component.Area);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of ComponentBase for each component
            ComponentBase table = new ComponentBase(cost: 100, weight: 20, area: 10);
            ComponentBase chair = new ComponentBase(cost: 50, weight: 10, area: 5);
            ComponentBase almirah = new ComponentBase(cost: 200, weight: 100, area: 15);
            ComponentBase tv = new ComponentBase(cost: 300, weight: 15, area: 8);
            ComponentBase light = new ComponentBase(cost: 20, weight: 2, area: 2);
            ComponentBase fan = new ComponentBase(cost: 50, weight: 5, area: 3);
            ComponentBase ac = new ComponentBase(cost: 500, weight: 50, area: 10);
            ComponentBase windows = new ComponentBase(cost: 30, weight: 5, area: 8);
            ComponentBase doors = new ComponentBase(cost: 40, weight: 8, area: 10);

            // Creating an instance of the Room class
            Room livingRoom = new Room();

            // Adding components to the room
            livingRoom.AddComponent(table);
            livingRoom.AddComponent(chair);
            livingRoom.AddComponent(almirah);
            livingRoom.AddComponent(tv);
            livingRoom.AddComponent(light);
            livingRoom.AddComponent(fan);
            livingRoom.AddComponent(ac);
            livingRoom.AddComponent(windows);
            livingRoom.AddComponent(doors);

            // Calculating and printing the total cost, weight, and area of the components in the room
            Console.WriteLine("Total Cost of Components in the Room: " + livingRoom.TotalCost());
            Console.WriteLine("Total Weight of Components in the Room: " + livingRoom.TotalWeight());
            Console.WriteLine("Total Area of Components in the Room: " + livingRoom.TotalArea());
            Console.ReadLine();
        }
    }
}
