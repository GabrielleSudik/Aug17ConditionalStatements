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
            //if statements
            //code executes if a certain condition is met

            //int age;

            //Console.WriteLine("How old are you, kid?");
            //age = int.Parse(Console.ReadLine());

            //if (age >= 17) //this kind of operator is a "relational" operator. it compares.
            //{
            //    Console.WriteLine("You can see this movie.");
            //}

            //if(age == 18) //you can have more than one "if" statement
            //   //if both are met, they will both run
            //   //but be careful about their order, they can mess up when "else" statements run
            //   //you intentionally left these in an illogical order
            //   //so you can see the "errors"
            //{
            //    Console.WriteLine("You are now an adult.");
            //}

            //else if(age == 21)
            //{
            //    Console.WriteLine("You are old enough to drink.");
            //}

            //else
            //{
            //    Console.WriteLine("Sorry, you are too young for this movie.");
            //}

            //Console.WriteLine("What is your grade in integers?");
            //int grade = int.Parse(Console.ReadLine());

            //if (grade >= 90 && grade <= 100) //note the && to bracket the range from 90 - 100
            //    //i feel like there's an easier way??
            //{
            //    Console.WriteLine("You got an A.");
            //}

            //else if (grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine("You got a B.");
            //}

            //else if (grade >=70 && grade <= 79)
            //{
            //    Console.WriteLine("You got a C. How mediocre.");
            //}

            //you don't NEED an else statement, but
            //they are useful for serving as a catch-all outside the if statements

            //last exercise of the night.
            //put here so you can just run code right away

            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());

            //you still don't quite understand modulo, but it works something like this:
            //you are dividing the user's number by 2.
            //if there is no remainder, it's even. if yes, it's odd.
            //i guess you write it like the below

            if (userNumber % 2 == 0)  
            {
                Console.WriteLine("You typed an even number.");
            }

            else
            {
                Console.WriteLine("You typed an odd number.");
            }

            //it's like, you wrote: if the number divided by x leaves a remainder of y...
            //in the below ex, if you divide by 7 and have a remainder of 0
            //yay you understood it!

            if (userNumber % 7 == 0)
            {
                Console.WriteLine("Your number is a mulitple of 7.");
            }

            else
            {
                Console.WriteLine("Your number is not a multiple of 7.");
            }

            //lol you can use the modulo code to play BizzBuzz

            Console.WriteLine("How many people were in your party?");
            int numberDiners = int.Parse(Console.ReadLine());

            Console.WriteLine("What was your total bill?");
            double totalBill = double.Parse(Console.ReadLine());

            if (totalBill >= 50)
            {
                Console.WriteLine("You all get a 10% discount!");

                double newBill = (totalBill * .9);

                //in class review, Jordan kept the variable as totalBill...
                //it just updated when run through the method/equation

                Console.WriteLine($"Your new total is ${newBill}.");
                Console.WriteLine($"Each person owes ${newBill/numberDiners}.");
            }

            else if (totalBill < 50)
            {
                Console.WriteLine("You all get a 5% discount!");

                double newBill = (totalBill * .95);

                Console.WriteLine("Your new total is " + newBill);
                Console.WriteLine($"Each person owes ${newBill / numberDiners}.");
            }

            Console.WriteLine("What is your grade in percentage?");
            int grade100 = int.Parse(Console.ReadLine());

            int grade = (grade100 / 10);

            if (grade == 10 || grade == 9) //note the && to bracket the range from 90 - 100
                                             //i feel like there's an easier way??
            {
                Console.WriteLine("You got an A.");
            }

            else if (grade == 8)
            {
                Console.WriteLine("You got a B.");
            }

            else if (grade == 7)
            {
                Console.WriteLine("You got a C. How mediocre.");
            }

            else if (grade <= 6)
            {
                Console.WriteLine("You big dummy!");
            }

            //class practice -- ages and if else
            Console.WriteLine("\nWelcome to the new school system!");
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Still a baby.");
            }

            else if (age == 3 || age == 4)
            {
                Console.WriteLine("Time for preschool.");
            }

            else if (age >5 && age <= 11)
            {
                Console.WriteLine("Elementary school.");
            }

            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle school.");
            }

            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High school.");
            }

            else
            {
                Console.WriteLine("You are no longer part of this school systems.");
            }

            //review:
            //bill = bill*discount is the same as bill *=discount
            //bill = bill+tip is the same as bill +=tip

            //class practice -- comparison of map coordinates

            //get coords of travel party
            //get coords of meeting point
            //give directions in N/NE/E etc from party to meeting point
            //coords of 0-100 on X and Y axes

            Console.WriteLine("Bob, what is your X coordinate on the map?");
            int bobX = int.Parse(Console.ReadLine());

            Console.WriteLine("Bob, what is your Y coordinate on the map?");
            int bobY = int.Parse(Console.ReadLine());

            Console.WriteLine("Lookout, what's the X coord of the overlook?");
            int overlookX = int.Parse(Console.ReadLine());

            Console.WriteLine("Lookout, what's the Y coord of the overlook?");
            int overlookY = int.Parse(Console.ReadLine());

            if (bobX == overlookX && bobY == overlookY)
            {
                Console.WriteLine("Congrats, you're where you want to be.");
            }

            else if (bobX == overlookX && bobY < overlookY)
            {
                Console.WriteLine("Walk directly north.");
            }

            else if (bobX == overlookX && bobY > overlookY)
            {
                Console.WriteLine("Walk directly south.");
            }

            else if (bobX < overlookX && bobY == overlookY)
            {
                Console.WriteLine("Walk directly east.");
            }

            else if (bobX > overlookX && bobY == overlookY) 
            {
                Console.WriteLine("Walk directly west.");
            }

            else
            {
                Console.WriteLine("You got bored and didn't finish the other four possibilities.");
            }



            //swwitch statements
            //useful when you are getting very specific inputs
            //ie, not ranges

            int pointsEarned = 2;
            //in a real example, get pointsEarned variable from user 1-3 and default

            switch (pointsEarned)
            {
                case 1:
                    Console.WriteLine("Needs practice.");
                    break;
                case 2:
                    Console.WriteLine("Not bad."  );
                    break;
                case 3:
                    Console.WriteLine("Excellent.");
                    break;
                default:
                    Console.WriteLine("Invalid score.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
