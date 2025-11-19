using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
