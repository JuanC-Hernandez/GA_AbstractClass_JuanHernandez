using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_JuanHernandez
{
    public class Faculty : Person   
    {
        // Fields and properties
        public string Role {  get; set; }   

        // Constructor
        public Faculty(string name, int id, string role) : base(name, id)
        { 
            Role = role;
        }
        // Override Method
        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, Role: {Role}";
        }
    }
}
