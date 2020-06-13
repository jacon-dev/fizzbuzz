using System;

namespace FizzBuzz
{
    public class MathsHelper
    {
        public int MultipleOf3or5orBoth(int number)
        {
            switch(number)
            {
                case int num when num % 3 == 0 && num % 5 == 0: return 15;
                case int num when num % 3 == 0: return 3;
                case int num when num % 5 == 0: return 5;
                default: return 0;
            }
        }

        // public bool MultipleOf3(int number)
        // {
        //     return number % 3 == 0;
        // }

        // public bool MultipleOf5(int number)
        // {
        //     return number % 5 == 0;
        // }

        // public bool MultipleOf3and5(int number)
        // {
        //     return number % 3 == 0 && number % 5 == 0;
        // }
    }
}