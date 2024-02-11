using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_JuanHernandez
{
    public class Mascot : Person
    {
        // Field and Properties
        public string Typeofmascot {  get; set; }   
        // Constructor
        public Mascot(string name, int id, string typeofmascot) : base(name, id)
        { 
            Typeofmascot = typeofmascot;
        }
        // Override method
        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, Type of Mascot: {Typeofmascot}";
        }
    }
}
