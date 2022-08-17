using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student jordan = new Student("Jordan", 1234, 1, 4.0);

            Console.WriteLine($"The Student class works! {jordan.Name} is a new student!");

        }
    }
}
