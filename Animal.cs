using System;

namespace DCIT318Assignment2
{
    // Base class demonstrating encapsulation with private fields and public properties
    public class Animal
    {
        // Private field (encapsulation)
        private string name;

        // Public property with getter and setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor
        public Animal(string name)
        {
            // Constructor initializes the animal's name
            this.Name = name;
        }

        // Virtual method to be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }
}
