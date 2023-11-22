using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Computer:ComponetBase
    {
        public string Type;
        public int Ram;
        public string Memory;
        public string Processor;
        public void show()
        {
            Console.WriteLine("Computer Type " + Type);
            Console.WriteLine("Computer Ram " + Ram);
            Console.WriteLine("Computer Memory " + Memory);
            Console.WriteLine("Computer Processor " + Processor);
            Console.WriteLine("Computer Cost: " + Cost);
            Console.WriteLine("Computer Weight: " + Weight);
            Console.WriteLine("Computer Area: " + Area);


        }
    }
 
}
