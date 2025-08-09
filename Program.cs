using System;
using System.Collections.Generic;

namespace DCIT318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display main menu and handle navigation
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.Clear();
                DisplayMainMenu();

                string choice = Console.ReadLine().Trim().ToLower();

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
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - Animals Demo");
            Console.WriteLine("2 - Shapes Demo");
            Console.WriteLine("3 - Movable Objects (Bicycle & Car)");
            Console.WriteLine("Type 'exit' to close the application.");
            Console.Write("> ");
        }

        static bool CheckForNavigation(string input)
        {
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0);
                return true;
            }
            else if (input.ToLower() == "end")
            {
                return true;
            }

            return false;
        }

        static bool PromptToContinue()
        {
            Console.WriteLine("\nDo you want to continue in this section? (yes/end/exit)");
            Console.Write("> ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response == "exit")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0);
                return false;
            }
            else if (response == "end" || response != "yes")
            {
                return false;
            }

            return true;
        }

        static void RunAnimalsDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Animals Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                try
                {
                    // Ask for dog name
                    Console.Write("Enter a name for a dog (or 'end' to return to menu, 'exit' to quit): ");
                    string dogName = Console.ReadLine();
                    if (CheckForNavigation(dogName)) return;

                    // Ask for cat name
                    Console.Write("Enter a name for a cat (or 'end' to return to menu, 'exit' to quit): ");
                    string catName = Console.ReadLine();
                    if (CheckForNavigation(catName)) return;

                    // Create animals and make sounds
                    Animal[] animals = new Animal[2];
                    animals[0] = new Dog(dogName);
                    animals[1] = new Cat(catName);

                    Console.WriteLine("\nAnimals making sounds:");
                    foreach (Animal animal in animals)
                    {
                        animal.MakeSound();
                    }

                    // Check if user wants to continue in this section
                    stayInSection = PromptToContinue();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    stayInSection = PromptToContinue();
                }
            }
        }

        static void RunShapesDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Shapes Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                try
                {
                    Console.WriteLine("Select shape:");
                    Console.WriteLine("1 - Circle");
                    Console.WriteLine("2 - Rectangle");
                    Console.WriteLine("Type 'end' to go back or 'exit' to quit.");
                    Console.Write("> ");

                    string choice = Console.ReadLine().Trim().ToLower();
                    if (CheckForNavigation(choice)) return;

                    switch (choice)
                    {
                        case "1": // Circle
                            Console.Write("Enter radius for a circle: ");
                            string radiusInput = Console.ReadLine();
                            if (CheckForNavigation(radiusInput)) return;

                            if (double.TryParse(radiusInput, out double radius) && radius > 0)
                            {
                                Circle circle = new Circle(radius);
                                Console.WriteLine($"\nCircle with radius {radius}:");
                                Console.WriteLine($"  Area: {circle.GetArea():F2}");
                                Console.WriteLine($"  Perimeter: {circle.GetPerimeter():F2}");
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
                                Rectangle rectangle = new Rectangle(width, height);
                                Console.WriteLine($"\nRectangle with width {width} and height {height}:");
                                Console.WriteLine($"  Area: {rectangle.GetArea():F2}");
                                Console.WriteLine($"  Perimeter: {rectangle.GetPerimeter():F2}");
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
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    stayInSection = PromptToContinue();
                }
            }
        }

        static void RunMovableObjectsDemo()
        {
            Console.Clear();
            Console.WriteLine("=== Movable Objects Program ===");

            bool stayInSection = true;
            while (stayInSection)
            {
                try
                {
                    Console.WriteLine("Select vehicle:");
                    Console.WriteLine("1 - Car");
                    Console.WriteLine("2 - Bicycle");
                    Console.WriteLine("Type 'end' to go back or 'exit' to quit.");
                    Console.Write("> ");

                    string choice = Console.ReadLine().Trim().ToLower();
                    if (CheckForNavigation(choice)) return;

                    switch (choice)
                    {
                        case "1": // Car
                            Console.Write("Enter a car brand: ");
                            string carBrand = Console.ReadLine();
                            if (CheckForNavigation(carBrand)) return;

                            Car car = new Car(carBrand);
                            car.Move();
                            break;

                        case "2": // Bicycle
                            Console.Write("Enter a bicycle type: ");
                            string bicycleType = Console.ReadLine();
                            if (CheckForNavigation(bicycleType)) return;

                            Bicycle bicycle = new Bicycle(bicycleType);
                            bicycle.Move();
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }

                    // Check if user wants to continue in this section
                    stayInSection = PromptToContinue();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    stayInSection = PromptToContinue();
                }
            }
        }
    }
}
