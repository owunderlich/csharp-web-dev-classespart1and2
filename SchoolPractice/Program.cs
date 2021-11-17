using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student Yolo = new Student("Yolo Swaggins", 69, 63, 4.00);
            Console.WriteLine($"{Yolo.Name}\n{Yolo.StudentId}\n{Yolo.NumberOfCredits}\n{Yolo.Gpa}");
            Yolo.AddGrade(4, 2.0);
            Console.WriteLine($"{Yolo.Name}\n{Yolo.StudentId}\n{Yolo.NumberOfCredits}\n{Yolo.Gpa}");
        }
    }
}
