using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);
            numbers.Add(30);
            numbers.Add(35);
            numbers.Add(40);
            numbers.Add(45);
            numbers.Add(50);         
            
            Console.WriteLine(CHOOSE A NUMBER TO DIVIDE ALL THE NUMBERS BY...");
            int divisor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                int answer = numbers[i] / divisor;
                Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + answer);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Use a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Don't divide by zero.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("You have exited the try/catch block. Ccontinue.");
            Console.ReadLine();
        }
    }
}












































