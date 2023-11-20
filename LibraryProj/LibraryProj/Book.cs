using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    public class Book
    {
        public String BookName;
        public String Title;
        public int ID;
        public string AutherName;

        public void show()
        {
            Console.WriteLine("Book Name: "+ BookName);
            Console.WriteLine("Book Title: "+ Title);
            Console.WriteLine("Book Id: "+ ID);
            Console.WriteLine("Auther Name: "+ AutherName);

        }
    }
   
}
