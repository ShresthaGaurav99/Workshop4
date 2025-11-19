using System;

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
    }
}
