using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObject
{
    internal class Student
    {
        int id;
        string name;
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 1;
            s1.name = "Bikash";
            Console.WriteLine(s1.name);
            Console.ReadLine();
        }
    }
}
