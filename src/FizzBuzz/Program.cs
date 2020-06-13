using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                // This example uses a maths helper that has a separate method for unit testable code
                var mathsHelper = new MathsHelper();
                switch(mathsHelper.MultipleOf3or5orBoth(i))
                {
                    case 15 : System.Console.WriteLine($"{i} FizzBuzz!"); break;
                    case 3 : System.Console.WriteLine($"{i} Fizz!"); break;
                    case 5 : System.Console.WriteLine($"{i} Buzz!"); break;
                    default: System.Console.WriteLine(i); break;
                }

                // The below works fine but doesnt have any testable code that can be used to create unit tests from.
                // It's what we call functional but also quick and dirty
                //
                // switch(i)
                // {
                //     case int num when num % 3 == 0 && num % 5 == 0 : Console.WriteLine($"{i} FizzBuzz!"); break;
                //     case int num when num % 3 == 0 : Console.WriteLine($"{i} Fizz!"); break;
                //     case int num when num % 5 == 0 : Console.WriteLine($"{i} Buzz!"); break;
                //     default: Console.WriteLine(i); break;
                // }

                // This section worked fine also but calling out to multiple methods using an if statement is not the best way to handle this
                //
                // if(mathsHelper.MultipleOf3and5(i)) Console.WriteLine($"{i} FizzBuzz");
                // else if(mathsHelper.MultipleOf3(i)) Console.WriteLine($"{i} Fizz");
                // else if(mathsHelper.MultipleOf5(i)) Console.WriteLine($"{i} Buzz");
                // else System.Console.WriteLine(i);
            }
        }
    }
}
