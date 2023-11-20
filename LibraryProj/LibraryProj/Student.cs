using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    public class Student
    {
        public int ID;
        public string Name;
        public int rollNO;
        public string department;
        public void show()
        {
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student rollNo: " + rollNO);
            Console.WriteLine("Student Department: " + department);
        }
    }
}
