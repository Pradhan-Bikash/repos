using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProj
{
    public class Library
    {
        //Books Object and List Class
        Book books1 = new Book();
        Book books2 = new Book();
        Book books3 = new Book();
        List<Book> book_list = new List<Book>();
        //Table Object And List CLass
        Table table1 = new Table();
        Table table2 = new Table();
        List<Table> table_list = new List<Table>();
        //Chair Object and List Class
        Chair chair1= new Chair();
        Chair chair2= new Chair();
        List<Chair> chair_list = new List<Chair>();
        //Student Object and List Class
        Student student1= new Student();
        Student student2= new Student();
        Student student3= new Student();
        Student student4= new Student();
        List<Student> student_list = new List<Student>();
        //

        public Library() {//constructor
            //Books
            books1.BookName = "400 Day";
            books1.Title = "Finding Sister";
            books1.ID = 1;
            books1.AutherName = "Chetan Bhagat";

            books2.BookName = "Programing With C ";
            books2.Title = "Programming";
            books2.ID = 2;
            books2.AutherName = "Herbert Schildt";

            books3.BookName = "Java ";
            books3.Title = "Programming";
            books3.ID = 3;
            books3.AutherName = "E Balagurusamy";

            book_list.Add(books1);
            book_list.Add(books2);
            book_list.Add(books3);

            // Table
            table1.type = "Plastic";
            table1.noOfTable = 3;

            table2.type = "Wood";
            table2.noOfTable = 10;

            table_list.Add(table1 );
            table_list.Add(table2 );

            //Chair
            chair1.type = "Plastic";
            chair1.noOfChair = 12;

            chair2.type = "Wood";
            chair2.noOfChair = 28;

            chair_list.Add(chair1);
            chair_list.Add(chair2);

            //Student
            student1.ID = 1;
            student1.Name = "Bikash";
            student1.rollNO = 10;
            student1.department = "Computer Science";

            student2.ID = 2;
            student2.Name = "Biku";
            student2.rollNO = 12;
            student2.department = "Civil";

            student3.ID = 3;
            student3.Name = "Amit";
            student3.rollNO = 13;
            student3.department = "Electrical";

            student4.ID = 3;
            student4.Name = "Raju";
            student4.rollNO = 14;
            student4.department = "Computer Science";

            student_list.Add(student1);
            student_list.Add(student2);
            student_list.Add(student3);
            student_list.Add(student4);
        }
        public void showAll()
        {
            foreach (var b in book_list) {
               b.show();
            }
            foreach (var t in table_list)
            {
                t.show();
            }
            foreach(var c in chair_list)
            {
                c.show();
            }
            foreach(var s in student_list)
            {
                s.show();
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Library b = new Library();
            b.showAll();
            Console.ReadLine(); 
            Library t = new Library();
            t.showAll();
            Library c = new Library();
            c.showAll();
            Library s= new Library();
            s.showAll();
        }
    }
}
