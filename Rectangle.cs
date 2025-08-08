namespace DCIT318Assignment2
{
    // Concrete class implementing abstract methods
    public class Rectangle : Shape
    {
        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementation of abstract method
        public override double GetArea()
        {
            return width * height;
        }

        // Implementation of abstract method
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
