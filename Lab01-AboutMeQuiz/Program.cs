using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun Quiz about Carlos Castillo");
            Question1();

            Question2();

            //Question3();

            //Question4();

            //Question5();
        }

        static string Question1()
        {
            Console.WriteLine("Does Carlos have a Mac or Windows laptop?");
            string input1 = Console.ReadLine();
            //string input1Caps = String.ToUpper(input1);
            if (input1 == "Mac")
            {
                Console.WriteLine("Correct. Carlos uses a Mac with BootCamp to run Windows.");
            }
            else
                Console.WriteLine("Sorry. Carlos uses a Mac with BootCamp to run Windows.");
            Console.ReadLine();
            return input1;
        }

        static byte Question2()
        {
            Console.WriteLine("How many pets does Carlos currently have at home?");
            string input2 = Console.ReadLine();
            byte input2Number = byte.Parse(input2);
            if (input2Number == 2)
            {
                Console.WriteLine("Correct.  Carlos has 1 dog & 1 cat.  They snuggle together.");
            }
            else
                Console.WriteLine("Sorry.  Carlos actually has 1 dog & 1 cat.  They snuggle together.");
            Console.ReadLine();
            return input2Number;
        }

        //question 3 Pokemon go? bool
        //question 4 choose carlos favorite morning drink, coffee, tea, energy drink, coke zero
        //question 5 Has Carlos lived in New York City?  true or false
        // You answered # questions correctly
    }
}
