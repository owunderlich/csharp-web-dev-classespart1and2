using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student me = new Student();
            me.Name = "Yolo Swaggins";
            me.NumberOfCredits = 100;
            me.Gpa = 4.5;
            me.StudentId = 0;
            Console.WriteLine($"Name: {me.Name}\n" +
                              $"Student ID: {me.StudentId}\n" +
                              $"Credits: {me.NumberOfCredits}\n" +
                              $"GPA: {me.Gpa}");
        }
    }
}
