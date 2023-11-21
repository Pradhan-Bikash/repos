using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Furniture:ComponentBase
    {
        public string Type;

    public void printShow()
        {
            Console.WriteLine("Type: "+Type);
        }
    }
}
