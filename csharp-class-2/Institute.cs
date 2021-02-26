using System;
using System.Collections.Generic;

namespace csharp_oop_intro
{
    class Institute
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public Institute(string name)
        {
            Name = name;
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        /*
         *  Create a new class "Institute", which contains a list of all courses, list of all students
         *  Write the following methods:
         *   - Get a list of all full courses
         *   - Get a list of all students with max allowed credits
         *   - List of all students who are in 3 waitinglists at least
         *   - The course with the max number of students
         *   - The course with max number of dropouts.         
         *   
         *   Create a collection in the course to represent the grades of students in this course. 
         *   // write a function to get the top student in a course
         *   // write a function to get the best course (top grade) for a student
         *   // write a function to get the GPA (from 0 to 4 of a student)
         *   // write a function to get the top student (top gpa)
         *      (We need access to the list of all students)
         *      (We need a way to get the GPA of individual students)
         */

        public List<Course> GetFullCourses()
        {
            var result = new List<Course>();
            foreach (var course in Courses)
                if (course.CurrentStudents.Count == course.MaxCapacity)
                    result.Add(course);

            return result;
        }

        public List<Student> GetStudentsWithMaxCredits()
        {
            List<Student> result = new List<Student>();

            foreach (var student in Students)
                if (student.getCurrentCredits() == Student.MAX_NUM_OF_CREDITS)
                    result.Add(student);

            return result;
        }

        public List<Student> GetStudentsInWaitingList(int NumOfCourses)
        {
            var result = new List<Student>();
            var dict = new Dictionary<Student, int>();

            foreach(var course in Courses)
            {
                foreach(var student in course.WaitingQueue)
                {
                    if (dict.ContainsKey(student))
                        dict[student]++;
                    else
                        dict.Add(student, 1);                 
                }
                foreach (var pair in dict)
                {
                    if (pair.Value >= NumOfCourses)
                        result.Add(pair.Key);
                }
            }      
            return result;
        }

        //public Course MaxStudentCourse()
        //{
            

        //    foreach(var course in Courses)
        //    {
        //        int maxCourseCount = course.MaxCapacity - course.CurrentStudents.Count;
        //        int maxCourse = 0;
                
        //        if(maxCourseCount > maxCourse)
        //        {
                                   
        //        }
        //    }
        //    return ;
        //}

        public Student GradeOfStudents()
        {
            Student topStudent = null;
            int topGrade = 0;

            foreach(var student in Students)
            {
                
            }
            return topStudent;
        }

        public Course BestGradeCourse()
        {
            Course bestCourse = null;

            return bestCourse;
        }

        public int GPA()
        {
            int GPA = 1;
            return GPA;
        }
        


    }
}

