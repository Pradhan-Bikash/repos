using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class TV:ComponetBase
    {
        public string Type;
        public int Quantity;
        public int Price;
        public int DisplaySize;
        public void show()
        {
            Console.WriteLine("Tv Type " + Type);
            Console.WriteLine("Tv Quantity " + Quantity);
            Console.WriteLine("Tv Price " + Price);
            Console.WriteLine("Tv Display Size " + DisplaySize);
            Console.WriteLine("Tv Cost: " + Cost);
            Console.WriteLine("Tv Weight: " + Weight);
            Console.WriteLine("Tv Area: " + Area);

        }
    }
}
