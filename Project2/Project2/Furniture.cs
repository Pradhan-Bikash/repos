using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project2
{
    public class Furniture:ComponentBase
    {
        public Furniture( string name, int weight, int price, double area) : base(name,weight,price,area){
           
        }
       public void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Weight);
            Console.WriteLine(Price);
            Console.WriteLine(Area);
        }

    }
}
