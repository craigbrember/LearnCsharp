using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************
             *
             *   CHAPTER 3 - THE WORLD OF VARIABLES AND OPERATORS
             *
             * * **************************************************/

            /* variables */
            byte userAge = 20;
            int numberOfEmployees = 510;
            double numberOfHours = 5120.5;
            float hourlyRate = 60.5f;
            decimal income = 25399.65m;
            char grade = 'A';
            bool promote = true;
            Console.WriteLine("userAge = " + userAge);
            Console.WriteLine("numberOfEmployees = " + numberOfEmployees);
            Console.WriteLine("numberOfHours = " + numberOfHours);
            Console.WriteLine("hourlyRate = " + hourlyRate);
            Console.WriteLine("income = " + income);
            Console.WriteLine("grade = " + grade);
            Console.WriteLine("promote = " + promote);

            /* basic operators */
            int x, y;
            x = 7; y = 2;
            Console.WriteLine("x + y = " + (x + y));
            Console.WriteLine("x - y = " + (x - y));
            Console.WriteLine("x * y = " + (x * y));
            Console.WriteLine("x / y = " + (x / y));
            Console.WriteLine("x % y = " + (x % y));
            Console.WriteLine("y - x = " + (y - x));

            /* if either x or y are non integers we will get a non integer answer */
            decimal x_dec = 7.0m;
            decimal y_dec = 2.0m;
            Console.WriteLine("x_dec / y = " + (x_dec / y));
            Console.WriteLine("x / y_dec = " + (x / y_dec));
            Console.WriteLine("x_dec / y_dec = " + (x_dec / y_dec));

            Console.WriteLine("x = " + x);
            x = x + 2;
            Console.WriteLine("x + 2 = " + x);

            x += 2;
            Console.WriteLine("x += 2 is " + x);

            x = x - 2;
            Console.WriteLine("x - 2 = " + x);

            x -= 2;
            Console.WriteLine("x -= 2 is " + x);

            x = x + 1;
            Console.WriteLine("x + 1 = " + x);

            x++;
            Console.WriteLine("x++ = " + x);

            x = x - 1;
            Console.WriteLine("x - 1 = " + x);

            x--;
            Console.WriteLine("x-- = " + x);

            Console.WriteLine("x = " + x);
            Console.WriteLine("x++ in write statement = " + x++);
            Console.WriteLine("value of x after x++ is " + x);
            Console.WriteLine("++x in write statement = " + ++x);
            Console.WriteLine("value of x after x++ is " + x);

            /* type casting */
            int z = (int)20.9;
            Console.WriteLine("type cast int z = " + z);

            /* instead of declaring a float or decimal by declaring a "f" or "m" suffix 
             * (see above) we can cast type instead */

            float num1 = (float)20.9;
            decimal num2 = (decimal)20.9;
            
            Console.Read();
        }
    }
}
