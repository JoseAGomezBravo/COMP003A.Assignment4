/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP-003A
 * Purpose: Replicate the output.
 */
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("For Loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.Write("Enter a positive whole number: ");
            string Limit = Console.ReadLine();
            int limit = Convert.ToInt32(Limit);

            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                    Console.WriteLine($"{output}");
                    output += "#";
            }

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = new string[] { "Racheal", "Joey", "Chandler", "Ross", "Monice", "Phoebe" };
            foreach (var friend in friends) 
            {
                Console.WriteLine($"{friend}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Do-while section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;

            do
            {
                Console.WriteLine($"{counter}");
                counter += 5;
            }while (counter <= 50);

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("While Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divsible by 2, output Foo");
            Console.WriteLine("If the number is divsible by 5, output Bar");
            Console.WriteLine("If the number is divsible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;

            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                if (counter2 % 5 == 0 && counter2 % 2 == 0)
                {
                    Console.WriteLine("Foobar");
                }
                else if (counter2 % 2 != 0 && counter2 % 5 != 0)
                {
                    Console.WriteLine($"{counter2}");
                }
                counter2++;
            }
        }
    }
}