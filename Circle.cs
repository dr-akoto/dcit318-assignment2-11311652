using System;

namespace DCIT318Assignment2
{
    // Concrete class implementing abstract methods
    public class Circle : Shape
    {
        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of abstract method
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Implementation of abstract method
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
