using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    public class Table
    {
        public string type;
        public int noOfTable;

        public void show()
        {
            Console.WriteLine("Table Type: "+ type);
            Console.WriteLine("No of Table: "+ noOfTable);

        }
    }
}
