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
     * 
     * Add the feild for NumofDropOuts for each course and implement the code.     
     * 
     * Implement: 
     *  A student who dropped out of a course can't register again for the same course.
     *  Add a max capacity for each course.
     *  
     *  Add a WaitingList for each course,
     *  when a user is trying to join a full course,
     *  the will be added to this waiting list.
     *  Once a user leaves a course that is full, 
     *  the first user in the waiting list will be added to the course. 
     */
     

    class Student
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Nationality { get; set; }
        public List<Course> Courses { get; set; }

        // Const versus readonly 
        // Const: has to be assigned right away, available for the entire class. 
        // readonly: does not have to be assigned right away (but can be), 
        //assign in constructor, only available for that instance. 
        // A "static" and "readonly" equal to const (compiled differently then const).

        public const int MAX_NUM_OF_CREDITS = 15;
        public readonly int Id;
        public static int TotalNumOfStudents;
        
        public Student(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
            Random r = new Random();
            Id = r.Next(1000, 10000);
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
            // MAX_NUM_OF_CREDITS // Can not change - no room for a mistake.
            if (!Courses.Contains(courseToJoin)
                    && getCurrentCredits() + courseToJoin.Credits <= MAX_NUM_OF_CREDITS
                    && !courseToJoin.DropOutStudents.Contains(this))
            {
                if (courseToJoin.CurrentStudents.Count < courseToJoin.MaxCapacity)
                {
                    Courses.Add(courseToJoin);
                    courseToJoin.CurrentStudents.Add(this);
                    Console.WriteLine("You have been added to the class: {0}", courseToJoin);
                }
                else // course is full
                {
                    courseToJoin.WaitingQueue.Enqueue(this);
                    Console.WriteLine("You have been added to the Queue for the course {0}", courseToJoin);
                }                
            }                              
        }

        public void LeaveCourse(Course courseToLeave)
        {
            // check all the buisness rules to leave a course.             
            if (Courses.Contains(courseToLeave))
            {
                Courses.Remove(courseToLeave);
                courseToLeave.NumOfDropOuts++;
                courseToLeave.DropOutStudents.Add(this);
                courseToLeave.CurrentStudents.Remove(this);
                if(courseToLeave.WaitingQueue.Count > 0) // if waiting list is not empty
                {
                    var firstStudentInQueue = courseToLeave.WaitingQueue.Dequeue();
                    firstStudentInQueue.JoinCourse(courseToLeave);
                    Console.WriteLine("You have been added to the class: {0}", courseToLeave);

                }                
            }
        }

        public void PrintAllCourses()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine("The student {0}, is in these courses:", Name);                
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
            Console.WriteLine("The maximum number of credits for this type is: {0}", MAX_NUM_OF_CREDITS);
        }


    }
}

