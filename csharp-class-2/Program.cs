using System;
using System.Collections.Generic;

namespace csharp_oop_intro
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Console.WriteLine("STUDENTS AND COURSES");
            //Student studentMike = new Student("Mike");
            //Student studentChris = new Student("Chris");
            //Course introToPrograming = new Course("Programming 101", 2, 3, 30);

            //Student.PrintMaxAllowedCredits();
            //// Student.MaxNumOfCredits = 20; // ERROR, can not change the const variable
            //Console.WriteLine(Student.MAX_NUM_OF_CREDITS);
            //Student.PrintMaxAllowedCredits();

            //studentMike.JoinCourse(introToPrograming);
            //studentMike.LeaveCourse(introToPrograming);
            //studentChris.JoinCourse(introToPrograming);

            //studentMike.getCurrentCredits();


            // studentMike.Id = 21315612 // Error, can not change a readonly 
            // Math n = new Math(); // Static class, Invalid Operation

            int x = 100; // value type
            Student s1 = new Student("Jay"); // reference type
            Student s2 = new Student("Chris");
            Student s3 = new Student("Jay");
            s3.Name = "Chris v2";
            Console.WriteLine(s2.Name);
            Console.WriteLine();
            // List<int> list = null; // reference type, points to null
            // list.Add(4);
            AlterValueUsingOut(out x);


            AlterValue(x);
            Console.WriteLine("Printing x inside the main after changing: {0} ", x);
            Console.WriteLine();
            AlterObject(s1);
            Console.WriteLine("name inside main after changing: {0}", s1.Name);
            Console.WriteLine();
            int y = 40;
            intChange(y);
            Console.WriteLine(y);

            string s = "Old Value";
            alterString(s);
            Console.WriteLine("String inside main after changing is: {0}", s);

            // out keyword example
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int valueInDictionary;
            if (dict.TryGetValue(5, out valueInDictionary) == true)
            {
                Console.WriteLine(valueInDictionary);
            }
            else
            {
                Console.WriteLine("This key does not exist. ");
            }
        }

        public static void AlterValue(int x)
        {
            x = 100;
            Console.WriteLine("Printing x inside the method. {0}", x);
        }

        public static void AlterValueWithRef(ref int x)
        {
            // x needs to be assigned before entering the method.
            x = 200;
            Console.WriteLine("Printing x inside the method. {0}", x);
        } // You do not assign or change the value in method // before you pass x you need to assign a value. 

        public static void AlterValueUsingOut(out int x) // x must be assigned before you leave the method. 
        {
            // x needs to be assigned before exiting this method. 
            x = 200;
            Console.WriteLine("Printing x inside the method. {0}", x);
        }

        public static void AlterObject(Student s)
        {
            s.Name = "Moe";
            Console.WriteLine("Name inside method {0}", s.Name);
        }

        public static void intChange(int x)
        {
            x = 500;
            Console.WriteLine("Changing int to {0} in the method.", x);
        }

        public static void alterString(string s)
        {
            s = "New Value";
            Console.WriteLine("string inside method is: {0}", s);
        }
    }
}
