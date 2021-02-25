using System;
using System.Collections.Generic;

namespace csharp_oop_intro
{
   
    static class MyStaticClass
    {
        static int id;
        static string name;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENTS AND COURSES");
            Student studentMike = new Student("Mike");
            Student studentChris = new Student("Chris");
            Course introToPrograming = new Course("Programming 101", 2, 3, 30);

            Student.PrintMaxAllowedCredits();
            // Student.MaxNumOfCredits = 20; // ERROR, can not change the const variable
            Console.WriteLine(Student.MAX_NUM_OF_CREDITS);
            Student.PrintMaxAllowedCredits();

            studentMike.JoinCourse(introToPrograming);
            studentMike.LeaveCourse(introToPrograming);
            studentChris.JoinCourse(introToPrograming);

            studentMike.getCurrentCredits();

            
            // studentMike.Id = 21315612 // Error, can not change a readonly 
            // Math n = new Math(); // Static class, Invalid Operation


        }
    }
}
