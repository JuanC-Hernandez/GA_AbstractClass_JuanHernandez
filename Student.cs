using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_JuanHernandez
{
    public class Student : Person
    {
        // Fields and Properties
        public double GPA { get; set; } 

        // Constructor
        public Student(string name, int id, double gpa) : base(name, id)
        {
            GPA = gpa;
        }

        // Override methods
        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, GPA: {GPA}";
        }
    }
}
