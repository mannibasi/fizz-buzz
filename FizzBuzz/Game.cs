using System;

namespace FizzBuzz
{
    public class Game
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        public Game()
        {
        }

        public String Play(int number)
        {
            if (DivisibleByThree(number) && DivisibleByFive(number))
            {
                return FIZZ + BUZZ;
            }

            if (DivisibleByThree(number))
            {
                return FIZZ;
            }

            if (DivisibleByFive(number))
            {
                return BUZZ;
            }

            return number.ToString();
        }

        private static bool DivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool DivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}