using System;

namespace DCIT318Assignment2
{
    // Derived class demonstrating inheritance and method overriding
    public class Cat : Animal
    {
        // Constructor calling the base class constructor
        public Cat(string name) : base(name)
        {
            // Constructor chaining calls the base (Animal) constructor
        }

        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Meows!");
        }
    }
}
