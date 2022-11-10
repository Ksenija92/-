// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System;
 
namespace ConsoleApplication11
{
    class Program
    {
        static void PrintReqursive(int number, int currentnumber = 15)
        {
            if (currentnumber >= number) return;
            Console.WriteLine(currentnumber);
            PrintReqursive(number,currentnumber+1);
        }
        
        static void Main()
        {
            PrintReqursive(26);
            Console.ReadKey();
        }
    }
}