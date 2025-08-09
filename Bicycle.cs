using System;

namespace DCIT318Assignment2
{
    // Class implementing an interface
    public class Bicycle : IMovable
    {
        // Private field with property (encapsulation)
        private string type;
        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Constructor
        public Bicycle(string type)
        {
            this.Type = type;
        }

        // Implementation of interface method
        public void Move()
        {
            Console.WriteLine($"Bicycle {Type} is moving");
        }
    }
}
