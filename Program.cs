namespace GA_AbstractClass_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Guided Assignment -  Abstract Classes
        // 02/10/2024
        static void Main(string[] args)
        {
            // Instance
            //Person person = new Person("John Doe", 12345);
            //Professor professor1 = new Professor("Dr. Smith", 101, "Computer Science");

            // Call method
            //string details = person.GetDetails();
            //string professorInfo = professor1.GetDetails();

            //Console.WriteLine(details);
            //Console.WriteLine("Professor Information:");
            //Console.WriteLine(professorInfo);

            // Create a list
            List<Person> schoolDatabase = new List<Person>();

            
            schoolDatabase.Add(new Student("John Doe", 12345, 3.8));
            schoolDatabase.Add(new Student("Alice Smith", 67890, 3.5));
            schoolDatabase.Add(new Professor("Dr. Smith", 101, "Computer Science"));
            schoolDatabase.Add(new Professor("Dr. Johnson", 102, "Mathematics"));
            schoolDatabase.Add(new Faculty("Jane Brown", 201, "Librarian"));
            schoolDatabase.Add(new Faculty("Mike Davis", 202, "Admissions"));
            schoolDatabase.Add(new Mascot("Larry", 86, "Eagle"));

            // Loop
            foreach (var person in schoolDatabase)
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}// Done