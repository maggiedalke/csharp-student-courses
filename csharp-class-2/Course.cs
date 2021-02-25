using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_oop_intro
{

    class Course
    {

        public string Name { get; set; }
        public int Duration { get; set; }
        public int Credits { get; set; }
        public int Capacity { get; set; }
        public int MaxCapacity { get; set; }
        public HashSet<Student> CurrentStudents { get; set; }
        public int NumOfDropOuts { get; set; }
        public int capacityOfClass;
        public int numOfstudents = 0;
        public HashSet<Student> DropOutStudents { get; set; }
        public Queue<Student> WaitingQueue { get; set; }


        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int duration, int credits, int MaxCapacity)
        {
            this.Name = name;
            this.Duration = duration;
            this.Credits = credits;
            this.Capacity = MaxCapacity;
        }


    }
}