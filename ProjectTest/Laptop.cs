using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Laptop:ComponetBase
    {
        public string Processor;
        public int Ram;
        public string Storage;
        public float DisplaySize;
        public void show()
        {

            Console.WriteLine("Laptop Processor: " + Processor);
            Console.WriteLine("Laptop Ram: " + Ram);
            Console.WriteLine("Laptop Storage: " + Storage);
            Console.WriteLine("Laptop Display Size: " + DisplaySize);
            Console.WriteLine("Laptop Cost: "+Cost);
            Console.WriteLine("Laptop Weight: " + Weight);
            Console.WriteLine("Laptop Area: " + Area);



        }
    }

    
}
