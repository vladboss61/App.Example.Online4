namespace ConsoleApp.GitExample;

using System;

internal class Program
{
    internal static void Main(string[] args)
    {
        Additional.SomethingToDisplay();
        Console.WriteLine("Hello");

        if (true)
        {
            Additional.SomethingToDisplay();
        }

    }
}
