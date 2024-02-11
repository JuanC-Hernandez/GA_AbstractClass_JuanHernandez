using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_JuanHernandez
{
    public class Professor : Person
    {
        // Fields and Properties
        public string Department { get; set; }
        // Constructor
        public Professor(string name, int id, string department) : base(name, id)
        { 
            Department = department;
        }
        // Override Method
        public override string GetDetails()
        {
            return $"{Name}. ID: {ID}, Department: {Department}";
        }
    }
}
