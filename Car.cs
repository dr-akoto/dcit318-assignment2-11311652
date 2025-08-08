using System;

namespace DCIT318Assignment2
{
    // Class implementing an interface
    public class Car : IMovable
    {
        // Private field with property (encapsulation)
        private string brand;
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Constructor
        public Car(string brand)
        {
            this.Brand = brand;
        }

        // Implementation of interface method
        public void Move()
        {
            Console.WriteLine($"Car {Brand} is moving");
        }
    }
}
