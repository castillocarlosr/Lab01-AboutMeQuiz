using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun Quiz about Carlos Castillo");
            Question1();

            Console.WriteLine("On to question 2");

            try
            {
                Question2();
            }
            catch (OverflowException error2) //To catch any number outside byte (0-255)
            {
                Console.WriteLine("Exception caught. You either think I have a lot more pets than possible or magically have negative pets.");
                Console.WriteLine(error2.Message);
            }
            catch (Exception error2All) //To catch any exception not expected.
            {
                Console.WriteLine("General Exception Caught.  I don't know what you typed but you broke it.  Thanks!");
                Console.WriteLine(error2All);
            }
            finally
            {
                Console.WriteLine("On to question 3");
                Console.ReadLine();
            }


            Question3();

            //Question4();

            //Question5();
        }

        static string Question1()
        {
            Console.WriteLine("Does Carlos have a Mac or Windows laptop?");
            string input1 = Console.ReadLine();
            string input1Caps = input1.ToUpper();
            if (input1Caps == "MAC")
            {
                Console.WriteLine("Correct. Carlos uses a Mac with BootCamp to run Windows.");
            }
            else
                Console.WriteLine("Sorry. Carlos uses a Mac with BootCamp to run Windows.");
            Console.ReadLine();
            return input1;
        }

        static byte Question2() //user should enter a number between 0-255
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

        static bool Question3()
        {
            Console.WriteLine("Carlos enjoys playing Pokemon Go.  \"true\" or \"false\".");
            string input3 = Console.ReadLine();  //Take in user input as string
            string input3Lower = input3.ToLower();  //convert user answer to lowercase
            bool input3Bool = Boolean.Parse(input3Lower); //conver that lowercase answer to true or false
            if (input3Bool == true)
            {
                Console.WriteLine("Correct.  He is a level 36 Poke-Master and will one day catch them all!");
            }
            else
                Console.WriteLine("Sorry.  He is serious about catching them all!  POKEMON!");
            Console.ReadLine();
            return input3Bool;
        }

        //question 3 Pokemon go? bool
        //question 4 choose carlos favorite morning drink, coffee, tea, energy drink, coke zero
        //question 5 Has Carlos lived in New York City?  true or false
        // You answered # questions correctly
    }
}
