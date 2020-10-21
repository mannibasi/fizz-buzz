using System;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var fizzBuzz = new Game();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Play(i));
            }
        }
    }
}