using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
    public class Room
    {
        Computer com = new Computer();
        Computer com2 = new Computer();
        Computer com3 = new Computer();
        List<Computer> comp = new List<Computer>();
       public Room ()  {
            com.type = Convert.ToString("PC");
            com.ram= 4;
            com.memory = Convert.ToString("1tb");
            com.memory = Convert.ToString("I5");
            com2.type = Convert.ToString("PC");
            com2.ram = 16;
            com2.memory = Convert.ToString("500GB");
            com2.memory = Convert.ToString("I3");
            com3.type = Convert.ToString("PC");
            com3.ram = 8;
            com3.memory = Convert.ToString("240GB");
            com3.memory = Convert.ToString("I7");
            comp.Add(com);
            comp.Add(com2);
            comp.Add(com3);
            
        }
        public void showAll()
        {
            foreach(var c in comp)
            {
                c.show();
            }
        }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Room r = new Room();
            r.showAll();
            Console.ReadLine();

        }
    }
}





 