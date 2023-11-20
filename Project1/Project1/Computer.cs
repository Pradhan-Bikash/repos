using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Computer
    {
        public string type;
        public int ram;
        public string memory;
        public string processor;
        public void show()
        {
            Console.WriteLine("type " + type);
            Console.WriteLine("ram " + ram);
            Console.WriteLine("memory " + memory);
            Console.WriteLine("Processor " + processor);


        }
    }
 
}
