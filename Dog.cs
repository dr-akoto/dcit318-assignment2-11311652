using System;

namespace DCIT318Assignment2
{
    // Derived class demonstrating inheritance and method overriding
    public class Dog : Animal
    {
        // Constructor calling the base class constructor (constructor chaining)
        public Dog(string name) : base(name)
        {
            // Constructor chaining calls the base (Animal) constructor
        }

        // Override the MakeSound method (polymorphism)
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Barks!");
        }
    }
}
