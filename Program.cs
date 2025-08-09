
using System;

namespace DCIT318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display main menu and handle navigation
            bool exitProgram = false;

            // Initial console setup - only set once
            Console.Title = "OOP Concepts Demo";

            while (!exitProgram)
            {
                // Clear once at the main menu only
                Console.Clear();
                DisplayMainMenu();

                string choice = Console.ReadLine()?.Trim().ToLower() ?? "";

                switch (choice)
                {
                    case "1":
                        RunAnimalsDemo();
                        break;
                    case "2":
                        RunShapesDemo();
                        break;
                    case "3":
                        RunMovableObjectsDemo();
                        break;
                    case "exit":
                        exitProgram = true;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void DisplayMainMenu()
        {
            // Use a single string for faster console output
            Console.WriteLine("=== Main Menu ===\n" +
                              "Select an option:\n" +
                              "1 - Animals Demo\n" +
                              "2 - Shapes Demo\n" +
                              "3 - Movable Objects (Bicycle & Car)\n" +
                              "Type 'exit' to close the application.");
            Console.Write("> ");
        }

        static bool CheckForNavigation(string input)
        {
            // Fast return if input is null or empty
            if (string.IsNullOrEmpty(input))
                return false;

            // Convert to lowercase once
            string lowerInput = input.ToLower();

            if (lowerInput == "exit")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0);
                return true;
            }
            else if (lowerInput == "n" || lowerInput == "end" || lowerInput == "back")
            {
                return true;
            }

            return false;
        }

        static bool PromptToContinue()
        {
            Console.Write("\nDo you want to continue in this section? (y/n/exit) > ");
            string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (response == "exit")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0);
                return false;
            }

            // Simple check for "y" to continue
            return response == "y";
        }

        static void RunAnimalsDemo()
        {
            // Only clear once at the beginning of the demo
            Console.Clear();
            Console.WriteLine("=== Animals Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                // Ask for dog name
                Console.Write("Enter a name for a dog: ");
                string dogName = Console.ReadLine();
                if (CheckForNavigation(dogName)) return;

                // Ask for cat name
                Console.Write("Enter a name for a cat: ");
                string catName = Console.ReadLine();
                if (CheckForNavigation(catName)) return;

                try
                {
                    // Create animals directly instead of using an array for small collections
                    Dog dog = new Dog(dogName);
                    Cat cat = new Cat(catName);

                    Console.WriteLine("\nAnimals making sounds:");
                    dog.MakeSound();
                    cat.MakeSound();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Check if user wants to continue in this section
                stayInSection = PromptToContinue();
            }
        }

        static void RunShapesDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Shapes Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                // Faster menu display
                Console.WriteLine("Select shape:\n" +
                                 "1 - Circle\n" +
                                 "2 - Rectangle\n" +
                                 "Type 'end' to go back or 'exit' to quit.");
                Console.Write("> ");

                string choice = Console.ReadLine()?.Trim().ToLower() ?? "";
                if (CheckForNavigation(choice)) return;

                switch (choice)
                {
                    case "1": // Circle
                        Console.Write("Enter radius for a circle: ");
                        string radiusInput = Console.ReadLine();
                        if (CheckForNavigation(radiusInput)) return;

                        if (double.TryParse(radiusInput, out double radius) && radius > 0)
                        {
                            try
                            {
                                Circle circle = new Circle(radius);
                                Console.WriteLine($"\nCircle with radius {radius}:");
                                Console.WriteLine($"  Area: {circle.GetArea():F2}");
                                Console.WriteLine($"  Perimeter: {circle.GetPerimeter():F2}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid radius. Please enter a positive number.");
                        }
                        break;

                    case "2": // Rectangle
                        Console.Write("Enter width for a rectangle: ");
                        string widthInput = Console.ReadLine();
                        if (CheckForNavigation(widthInput)) return;

                        Console.Write("Enter height for a rectangle: ");
                        string heightInput = Console.ReadLine();
                        if (CheckForNavigation(heightInput)) return;

                        if (double.TryParse(widthInput, out double width) && width > 0 &&
                            double.TryParse(heightInput, out double height) && height > 0)
                        {
                            try
                            {
                                Rectangle rectangle = new Rectangle(width, height);
                                Console.WriteLine($"\nRectangle with width {width} and height {height}:");
                                Console.WriteLine($"  Area: {rectangle.GetArea():F2}");
                                Console.WriteLine($"  Perimeter: {rectangle.GetPerimeter():F2}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid dimensions. Please enter positive numbers.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                // Check if user wants to continue in this section
                stayInSection = PromptToContinue();
            }
        }

        static void RunMovableObjectsDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Movable Objects Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                // Faster menu display
                Console.WriteLine("Select vehicle:\n" +
                                 "1 - Car\n" +
                                 "2 - Bicycle\n" +
                                 "Type 'end' to go back or 'exit' to quit.");
                Console.Write("> ");

                string choice = Console.ReadLine()?.Trim().ToLower() ?? "";
                if (CheckForNavigation(choice)) return;

                switch (choice)
                {
                    case "1": // Car
                        Console.Write("Enter a car brand: ");
                        string carBrand = Console.ReadLine();
                        if (CheckForNavigation(carBrand)) return;

                        try
                        {
                            Car car = new Car(carBrand);
                            car.Move();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case "2": // Bicycle
                        Console.Write("Enter a bicycle type: ");
                        string bicycleType = Console.ReadLine();
                        if (CheckForNavigation(bicycleType)) return;

                        try
                        {
                            Bicycle bicycle = new Bicycle(bicycleType);
                            bicycle.Move();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                // Check if user wants to continue in this section
                stayInSection = PromptToContinue();
            }
        }
    }
}
