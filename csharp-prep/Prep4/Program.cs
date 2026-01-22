using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
    int number = 0;
    int sum = 0;


    List <int> numbers = new List<int> (); 
    Console.WriteLine("Enter a list of Numbers, type 0 when you're done. ");

        do
        {
        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());
        if (number != 0)
        {
        numbers.Add(number);  
        }
        }while (number != 0);
    
    foreach (int n in numbers)
        {
            sum += n;
        }
    Console.WriteLine($"The sum of this list is: {sum}");

    Console.WriteLine($"The number of elements in the list is {numbers.Count}.");

    double average = (double)sum / numbers.Count ();

    Console.WriteLine($"The average is: {average}.");
    
    int largest = numbers[0];

    foreach (int n in numbers)
    {
        if (n > largest)
        {
            largest = n;
        }
    }
    Console.WriteLine($"The largest number in the list is: {largest}. ");

    int smallest = numbers[0];

    foreach (int n in numbers)
    {
        if (n < smallest)
        {
            smallest = n;
        }
    }
    Console.WriteLine($"The smallest number in the list is: {smallest}. ");

    numbers.Sort();
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }
    }

}
