# DCIT318 Assignment 2: OOP Concepts Demo

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Code Organization](#code-organization)
- [OOP Concepts Demonstrated](#oop-concepts-demonstrated)
- [Development](#development)
- [Troubleshooting](#troubleshooting)
- [Contributors](#contributors)

## Overview
This project demonstrates fundamental Object-Oriented Programming (OOP) concepts through a menu-driven C# console application. It includes examples of inheritance, abstraction, polymorphism, encapsulation, and interfaces.

## Features
- Interactive menu-based console application
- Three demonstration modules:
  1. Inheritance Demo: Shows inheritance relationships between Animal base class and Dog/Cat derived classes
  2. Abstract Class Demo: Demonstrates abstraction with Shape abstract class and Circle/Rectangle concrete implementations
  3. Interface Demo: Showcases interface implementation with IMovable interface and Car/Bicycle classes
- User input for customizing demonstrations
- Easy launch scripts for running the application

## Project Structure
```
InheritanceDemo/
│
├── Animal.cs          # Base class for inheritance demonstration
├── Cat.cs             # Derived class from Animal
├── Dog.cs             # Derived class from Animal
│
├── Shape.cs           # Abstract base class for abstraction demonstration
├── Circle.cs          # Concrete implementation of Shape
├── Rectangle.cs       # Concrete implementation of Shape
│
├── IMovable.cs        # Interface for interface demonstration
├── Car.cs             # Class implementing IMovable interface
├── Bicycle.cs         # Class implementing IMovable interface
│
├── Program.cs         # Main application entry point with menu system
├── InheritanceDemo.csproj  # Project file
│
├── start.bat          # Batch file launcher
├── start.ps1          # PowerShell launcher script
└── README.md          # This documentation file
```

## Setup and Installation

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- Windows operating system (for batch file execution)

### Installation Steps
1. Clone the repository:
   ```
   git clone https://github.com/dr-akoto/dcit318-assignment2-11311652.git
   ```

2. Navigate to the project directory:
   ```
   cd dcit318-assignment2-11311652/InheritanceDemo
   ```

3. Build the project:
   ```
   dotnet build
   ```

## Usage

### Running the Application
You can run the application in several ways:

#### Method 1: Using the Start Batch File
Simply double-click the `start.bat` file in Windows Explorer, or run it from a terminal:
```
.\start.bat
```

#### Method 2: Using .NET CLI
Navigate to the project directory and run:
```
dotnet run --project InheritanceDemo.csproj
```

### Using the Application
1. When the application starts, you'll see a menu with four options:
   ```
   === DCIT318 Assignment 2: OOP Concepts Demo ===
   1. Inheritance Demo (Animal, Dog, Cat)
   2. Abstract Class Demo (Shape, Circle, Rectangle)
   3. Interface Demo (IMovable, Car, Bicycle)
   4. Exit

   Enter your choice (1-4):
   ```

2. Enter your choice (1-4) to navigate to the corresponding demonstration.

3. Follow the prompts in each demonstration to see OOP concepts in action.

4. After each demonstration, you'll be asked if you want to try another example or return to the main menu.

## Code Organization

### Base Classes and Interfaces
- `Animal`: Base class demonstrating encapsulation with private fields and properties
- `Shape`: Abstract base class with abstract methods that derived classes must implement
- `IMovable`: Interface that defines a contract for objects that can move

### Derived Classes
- `Dog` and `Cat`: Extend Animal and override the MakeSound method (polymorphism)
- `Circle` and `Rectangle`: Implement Shape abstract class by providing concrete implementations for GetArea and GetPerimeter
- `Car` and `Bicycle`: Implement IMovable interface by providing implementation for the Move method

### Main Program
The `Program.cs` file contains the main menu and the methods for each demonstration:
- `Main`: Entry point with the menu loop
- `InheritanceDemo`: Demonstrates inheritance concept
- `AbstractClassDemo`: Demonstrates abstract classes
- `InterfaceDemo`: Demonstrates interfaces

## OOP Concepts Demonstrated

### 1. Inheritance
Demonstrated through the Animal, Dog, and Cat classes:
- Animal is the base class
- Dog and Cat inherit from Animal
- Code example:
  ```csharp
  public class Animal { ... }
  public class Dog : Animal { ... }
  public class Cat : Animal { ... }
  ```

### 2. Abstraction
Demonstrated through the Shape, Circle, and Rectangle classes:
- Shape is an abstract class with abstract methods
- Circle and Rectangle provide concrete implementations
- Code example:
  ```csharp
  public abstract class Shape { 
      public abstract double GetArea();
  }
  public class Circle : Shape {
      public override double GetArea() { ... }
  }
  ```

### 3. Polymorphism
Demonstrated through method overriding:
- Animal has a virtual MakeSound method
- Dog and Cat override this method with specific implementations
- Code example:
  ```csharp
  // In Animal class
  public virtual void MakeSound() { ... }
  
  // In Dog class
  public override void MakeSound() { ... }
  ```

### 4. Encapsulation
Demonstrated through private fields with public properties:
- Animal class has private fields with public properties
- Code example:
  ```csharp
  private string name;
  public string Name
  {
      get { return name; }
      set { name = value; }
  }
  ```

### 5. Interfaces
Demonstrated through the IMovable interface with Car and Bicycle implementations:
- IMovable defines a contract
- Car and Bicycle implement this interface
- Code example:
  ```csharp
  public interface IMovable {
      void Move();
  }
  public class Car : IMovable { ... }
  ```

## Development

### Adding New Features
To extend the application with new features:

1. Add new classes in separate files
2. Update the Program.cs file to include new menu options
3. Create new demonstration methods for your features

### Building for Release
To build a release version:
```
dotnet publish -c Release
```

The output will be in the `bin/Release/net6.0/publish` directory.

## Troubleshooting

### Common Issues
1. **"Error MSB1011: Specify which project or solution file to use"**
   - Solution: Specify the project file explicitly
   ```
   dotnet run --project InheritanceDemo.csproj
   ```

2. **"The system cannot find the file specified" when using 'start' command**
   - Solution: Use the full path or use .\start.bat instead

3. **Build errors related to missing references**
   - Solution: Restore NuGet packages
   ```
   dotnet restore
   ```

## Contributors
- [Your Name] - [Your Email]
- University of Ghana, Department of Computer Science

---
© 2025 DCIT318 Assignment 2
