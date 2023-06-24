using System;

namespace ConsoleApp4
{
    public class person
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string age { get; set; }
    }

    public class teacher : person
    {
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
    }

    public class student : person

    {
        public void Learn()
        {
            Console.WriteLine("Learning...");

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            teacher teacher = new teacher();
            student student = new student();

            teacher.name = "name";
            teacher.surname = "surname";
            teacher.age = "21";

            Console.WriteLine(teacher.name + "  " + teacher.surname + "  " + teacher.age);
            teacher.Explain();

            student.name = "name";
            student.surname = "surname";
            student.age = "31";

            Console.WriteLine(student.name + "  " + student.surname + "  " + student.age);
            student.Learn();


        }

    }
}