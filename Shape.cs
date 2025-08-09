namespace DCIT318Assignment2
{
    // Abstract class demonstrating abstraction
    public abstract class Shape
    {
        // Protected fields accessible to derived classes
        protected double radius;
        protected double width;
        protected double height;

        // Abstract methods (must be implemented by derived classes)
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
