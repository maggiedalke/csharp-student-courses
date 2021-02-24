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

        public Course(string name)
        {
            this.Name = name;
        }
        public Course(string name, int duration, int credits)
        {
            this.Name = name;
            this.Duration = duration;
            this.Credits = credits;
        }


    }
}