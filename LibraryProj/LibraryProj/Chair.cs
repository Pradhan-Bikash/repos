using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    public class Chair
    { 
            public string type;
            public int noOfChair;
        public void show()
        {
            Console.WriteLine("Chair Type: " + type);
            Console.WriteLine("No of Chair: " + noOfChair);

        }
        }
}
