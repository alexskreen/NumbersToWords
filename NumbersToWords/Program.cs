using System;
using NumbersToWords.Models;

namespace NumbersToWords.Program
{
    public class Program
    {
        public static void Main()
        {
            Number userNumber = new Number(16);
            // userNumber.WordNumber();
            Console.WriteLine(userNumber.WordNumber());
        }
    }
}