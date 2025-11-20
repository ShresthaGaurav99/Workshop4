using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Task1
        // Creating first object
        Student s1 = new Student();
        s1.Name = "Gaurav";
        s1.Age = 21;
        s1.Address = "Dharan";

        // Creating second object
        Student s2 = new Student();
        s2.Name = "Dev";
        s2.Age = 21;
        s2.Address = "Ithari";

        // Display values of first object
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
        Console.WriteLine("Address: " + s1.Address);

        Console.WriteLine();

        // Display values of second object
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.Name);
        Console.WriteLine("Age: " + s2.Age);
        Console.WriteLine("Address: " + s2.Address);

        Console.WriteLine();

        // Display static field
        Console.WriteLine("College Name: " + Student.CollegeName);

        //Task2
        // creating an object of Calculator
        Calculator calc = new Calculator();

        // calling the welcome message
        calc.PrintWelcome();

        // calling Add method
        int sum = calc.Add(10, 20);

        // calling Multiply method (both parameters)
        int product1 = calc.Multiply(5, 3);

        // calling Multiply with optional parameter (num2 = default 1)
        int product2 = calc.Multiply(7);

        // printing values
        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Multiplication (5 * 3): " + product1);
        Console.WriteLine("Multiplication with default (7 * 1): " + product2);

        //Task3
        // Create object of ParameterDemo
        ParameterDemo demo = new ParameterDemo();

        // 1. Calling Increase() using ref
        int myNumber = 20;
        demo.Increase(ref myNumber);
        Console.WriteLine("After Increase: " + myNumber);

        // 2. Calling GetFullName() using out
        string fullName;
        demo.GetFullName(out fullName);
        Console.WriteLine("Full Name: " + fullName);

        // 3. Calling SumAll() using params
        int total = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);

        //Task4
        // 1. Object using default constructor
        Player p1 = new Player();
        Console.WriteLine("\nPlayer 1 Details:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        // 2. Object using parameterized constructor
        Player p2 = new Player("Gaurav", 5, 100);
        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);

        //Task5

        // - PART 1: DayType Enum Logic -
        Console.Write("Enter a day: ");
        string inputDay = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (inputDay == "friday" || inputDay == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");

        // - PART 2: Book Record -
        // First object
        Book b1 = new Book("C# Basics", "John Smith", 499.99);

        // Create new object using with expression
        Book b2 = b1 with { title = "Advanced C#", price = 799.50 };

        // Print first object's values
        Console.WriteLine("\nFirst Book:");
        Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");

        // Deconstruct second object
        var (title, author, price) = b2;

        Console.WriteLine("\nSecond Book (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");

        //Task6
        Console.Write("Enter marks: ");
        bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        bool isTotalValid = int.TryParse(Console.ReadLine(), out int total);

        if (!isMarksValid || !isTotalValid)
        {
            Console.WriteLine("Invalid input! Please enter valid integers.");
            return;
        }

        // 🔴 BREAKPOINT 1: Set breakpoint here (before calculation)

        double percentage = (double)marks / total * 100;

        // 🔵 BREAKPOINT 2: Set breakpoint here (after calculation)

        Console.WriteLine("Percentage = " + percentage + "%");

        //  Breakpoint 1
        //You'll see that: 
        //marks is an integer

        //total is an integer

        //Breakpoint 2
        //You will notice the percentage value is incorrect when calculated with double percentage = marks / total * 100;

        //The output is incorrect because both marks and total are integers, so the division marks / total performs integer division,
        //which truncates any decimal part. This means that if marks is less than total, the result of the division will be 0, leading to an incorrect percentage calculation.
        
        //We can fix this by casting either marks or total to double before the division to ensure that floating-point division is performed.


    }
}
