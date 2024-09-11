/*
 * INFO 350 - Assignment Coin Change
 * 
 * <replace with your name>
 * 
 * COIN CHANGE
 * 
 * Write a program in C# that computes and prints the number of quarters,
 * dimes, nickels, and pennies that a customer should get back as change. 
 * 
 * 
 * Modify this code to complete this assignment
 */


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? inputString;
            Decimal inputChangeToGive;

            Console.WriteLine("Type in the amount of change to give: ");

            // reads in a string from the console
            inputString = Console.ReadLine();

            // checks that we got a string back instead of a null
            // note we have not covered null yet
            if (inputString == null || !Decimal.TryParse(inputString, out inputChangeToGive))
            {
                Console.WriteLine("Not a valid decimal, exiting...");
                return;
            }

            Console.WriteLine("Given the value " + inputChangeToGive);
        }
    }
}