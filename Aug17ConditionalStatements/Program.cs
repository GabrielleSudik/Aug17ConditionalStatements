using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug17ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("How old are you, kid?");
            age = int.Parse(Console.ReadLine());

            if (age >= 17)
            {
                Console.WriteLine("You can see this movie.");
            }

            else
            {
                Console.WriteLine("Sorry, you are too young for this movie.");
            }
            Console.ReadLine();
        }
    }
}
