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
            Course introToPrograming = new Course("Programming 101", 2, 3);

            Student.PrintMaxAllowedCredits();

            studentMike.JoinCourse(introToPrograming);
            studentMike.LeaveCourse(introToPrograming);
            studentChris.JoinCourse(introToPrograming);

            studentMike.getCurrentCredits();
            Math.

        }
    }
}
