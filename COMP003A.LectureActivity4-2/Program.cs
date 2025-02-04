// Author: Angel Gomez
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Practice implementing methods in C#
namespace COMP003A.LectureActivity4_2;

class Program
{
    static void Main(string[] args)
    {
        // Greet the user with the method 
        GreetUser();
        
        // Input two numbers and calculate the sum using method 
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int sum = CalculateSum(num1, num2); // Call the method and store the result as "sum"
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}. ");
        
        // Display the contents of an array using method 
        int[] numbers = { 10, 20, 30, 40, 50, 60}; // Initialize the array 
        Console.WriteLine("Array contents: ");
        DisplayArray(numbers); // Call the method to display the array 
    }
    
    // Greets user by their name 
    static void GreetUser()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); 
        Console.WriteLine($"Hello, {name}! Welcome to the Methods Activity. ");
    }

    // Calculates the sum of two numbers and returns the result 
    static int CalculateSum(int num1, int num2)
    {
        return num1 + num2; // Add then return the result 
    }
    
    // Displays the contents of an array 
    static void DisplayArray(int[] numbers)
    {
        foreach (int num in numbers) // Loop through the array 
        {
            Console.WriteLine(num); // Print each number 
        }
    }
}