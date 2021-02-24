using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_oop_intro
{
    /* Create a class "Student" that contains few student 
     * properties like (Name, Birthday Nationality)
     * and 2 different constructors, one that takes only 
     * the name and another on that takes all the fields.
     * 
     * Create another class called "Course", a course has 
     * a Name, Duration in months, and number of credits. 
     * 
     * In the Student class, create another property for 
     * Students called "Courses", which is a list of courses
     * that a student is enroller in. 
     * 
     * In Student class, write two functions, JoinCourse and 
     * Leave to handle the enrollment. 
     * 
     * Also, write a function to print the list of courses
     * 
     * Change the student class so the student can only have
     * 15 credits of courses at the same time. 
     
     */
    class Student
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Nationality { get; set; }
        public List<Course> Courses { get; set; }

        public static int MaxNumOfCredits = 15;
        public static int TotalNumOfStudents; 

        public Student(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
            TotalNumOfStudents++;
        }

        public Student(string name, string birthday, string nationality)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Nationality = nationality;
            this.Courses = new List<Course>();
            TotalNumOfStudents++;
        }

        public void JoinCourse(Course courseToJoin)
        {
            // check if this student can join this course.            
            // The student does not have the course in their current list
            // The students total number of credits will not be > than max(15 in this case). 
            if (!Courses.Contains(courseToJoin) && getCurrentCredits() + courseToJoin.Credits <= 15)
                Courses.Add(courseToJoin);
        }

        public void LeaveCourse(Course courseToLeave)
        {
            // check all the buisness rules to leave a course. 
            if (Courses.Contains(courseToLeave))
                Courses.Remove(courseToLeave);
        }

        public void PrintAllCourses()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine("The student {0}, is in these courses:", this.Name);
                Console.WriteLine(course.Name);
            }
        }

        public int getCurrentCredits()
        {
            int total = 0;

            foreach (var course in Courses)
            {
                total = total + course.Credits;
            }
            return total;
        }

        public static void PrintMaxAllowedCredits()
        {
            Console.WriteLine();
            Console.WriteLine("The maximum number of credits for this type is: {0}", MaxNumOfCredits);
        }


    }
}

