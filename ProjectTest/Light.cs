using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Light:ComponetBase
    {
        public string Type;
        public string Brand;
        public int Price;
        public void show()
        {
            Console.WriteLine("Light Type: " + Type);
            Console.WriteLine("Light Brand: " + Brand);
            Console.WriteLine("Light Price: " + Price);
            Console.WriteLine("Light Cost: " + Cost);
            Console.WriteLine("Light Weight: " + Weight);
            Console.WriteLine("Light Area: " + Area);

        }
    }
}
