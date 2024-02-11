using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_JuanHernandez
{
    public abstract class Person
    {
        // Fields
        public string Name { get; set; }
        public int ID { get; set; } 

        // Constructor
        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
        // Methods
        public abstract string GetDetails();
    }
}
