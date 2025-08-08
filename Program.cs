using System;
using DCIT318Assignment2;

namespace DCIT318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== DCIT318 Assignment 2: OOP Concepts Demo ===");
                Console.WriteLine("1. Inheritance Demo (Animal, Dog, Cat)");
                Console.WriteLine("2. Abstract Class Demo (Shape, Circle, Rectangle)");
                Console.WriteLine("3. Interface Demo (IMovable, Car, Bicycle)");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InheritanceDemo();
                        break;
                    case "2":
                        AbstractClassDemo();
                        break;
                    case "3":
                        InterfaceDemo();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void InheritanceDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Inheritance Demo ===");
            Console.WriteLine("This demonstrates inheritance with Animal as base class and Dog/Cat as derived classes.\n");

            Console.Write("Enter a name for a dog: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter a name for a cat: ");
            string catName = Console.ReadLine();

            // Create instances
            Dog dog = new Dog(dogName);
            Cat cat = new Cat(catName);

            Console.WriteLine("\nDemonstrating polymorphism with MakeSound() method:");
            Console.WriteLine("Dog instance:");
            dog.MakeSound();

            Console.WriteLine("\nCat instance:");
            cat.MakeSound();

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void AbstractClassDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Abstract Class Demo ===");
            Console.WriteLine("This demonstrates abstraction with Shape as abstract class and Circle/Rectangle as concrete implementations.\n");

            Console.Write("Enter radius for a circle: ");
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("Invalid input. Using default value of 5.");
                radius = 5;
            }

            Console.Write("Enter width for a rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Invalid input. Using default value of 4.");
                width = 4;
            }

            Console.Write("Enter height for a rectangle: ");
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid input. Using default value of 6.");
                height = 6;
            }

            // Create instances
            Circle circle = new Circle(radius);
            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine($"\nCircle with radius {radius}:");
            Console.WriteLine($"Area: {circle.GetArea():F2}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter():F2}");

            Console.WriteLine($"\nRectangle with width {width} and height {height}:");
            Console.WriteLine($"Area: {rectangle.GetArea():F2}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter():F2}");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void InterfaceDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Interface Demo ===");
            Console.WriteLine("This demonstrates interfaces with IMovable interface implemented by Car and Bicycle classes.\n");

            Console.Write("Enter a brand for a car: ");
            string carBrand = Console.ReadLine();

            Console.Write("Enter a type for a bicycle: ");
            string bicycleType = Console.ReadLine();

            // Create instances
            Car car = new Car(carBrand);
            Bicycle bicycle = new Bicycle(bicycleType);

            Console.WriteLine("\nDemonstrating interface implementation with Move() method:");

            Console.WriteLine("Car instance:");
            car.Move();

            Console.WriteLine("\nBicycle instance:");
            bicycle.Move();

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
 