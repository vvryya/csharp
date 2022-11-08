using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
    }

    class Professional : Person
    {
        public string Profession { get; set; }
    }

    class Programmer : Professional
    {
        public Programmer()
        {
            Profession = "Programmer";
        }
        
        public void OutputInfo()
        {
            Console.WriteLine($"Hello, my name is {Name}, I'm a {Profession}");
        }
    }

    public class ProgrammerISAProfessional
    {
        public static void Main()
        {
            var programmer = new Programmer
            {
                Name = "John",
            };

            programmer.OutputInfo();
        }
    }
}