using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personName = new Person();
            Student whyAShe = new Student();
            whyAShe.setAge(20);
            whyAShe.Greet();
            whyAShe.Study();
            whyAShe.ShowAge();
            Teacher teacherName = new Teacher();
            teacherName.setAge(40);
            teacherName.Explain();
            Console.WriteLine("\nWould getters and setters have been accepted instead of .setAge(x)?");
        }
    }
}