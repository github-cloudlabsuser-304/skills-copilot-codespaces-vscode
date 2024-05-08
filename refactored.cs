using System;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr)
    {
        int result = 0;
        foreach (int num in arr)
        {
            result += num;
        }
        return result;
    }

    static int GetNumberFromUser(string prompt)
    {
        Console.Write(prompt);
        if (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Environment.Exit(1);
        }
        return result;
    }

    static void Main()
    {
        int n = GetNumberFromUser("Enter the number of elements (1-100): ");
        if (n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
            Environment.Exit(1);
        }

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = GetNumberFromUser($"Enter integer {i+1}: ");
        }

        int total = Sum(arr);

        Console.WriteLine("Sum of the numbers: " + total);
    }
}