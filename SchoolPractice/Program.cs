using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student jordan = new Student("Jordan", 1234, 15, 4.0);

            Student josh = new Student("Josh");

            Student aaron = new Student("Aaron");

            Console.WriteLine($"The Student class works! {jordan.Name} is a transfer student!");
            Console.WriteLine($"{jordan.Name} {jordan.StudentId} {jordan.NumberOfCredits} {jordan.Gpa}");

            Console.WriteLine($"The Student class works! {josh.Name} is a new student!");
            Console.WriteLine($"{josh.Name} {josh.StudentId} {josh.NumberOfCredits} {josh.Gpa}");

            Console.WriteLine($"The Student class works! {aaron.Name} is a new student!");
            Console.WriteLine($"{aaron.Name} {aaron.StudentId} {aaron.NumberOfCredits} {aaron.Gpa}");


            Console.WriteLine($"{jordan.Name} is a {jordan.GetGradeLevel(15)}");

            Console.WriteLine(jordan.ToString());


            Teacher lisa = new Teacher("Lisa", "Smith", "algebra", 32);


            Course alegbra = new Course("algebra", lisa);

            Console.WriteLine(alegbra.ToString());


        }
    }
}
