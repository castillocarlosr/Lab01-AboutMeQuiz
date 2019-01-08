using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        public static int counter = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Fun Quiz about Carlos Castillo");
            //I left question 1 without a try-catch block as any answer is possible.
            Question1();
            Console.WriteLine("On to question 2");

            //try block for question 2
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

            //try-catch block for question 3
            try
            {
                Question3();
            }
            catch (FormatException error3)
            {
                Console.WriteLine("Exception caught.  This isn't Javascript.  You need to type in true or false.");
                Console.WriteLine(error3);
            }
            catch(Exception error3All)
            {
                Console.WriteLine("General Exception Caught.  I don't know what you typed but you broke it.  Thanks!");
                Console.WriteLine(error3All);
            }
            finally
            {
                Console.WriteLine("On to question 4");
                Console.ReadLine();
            }

            //Any possible answer so no try-catch block needed.
            Question4();
            Console.WriteLine("On to question 4");

            //Question5
            try
            {
                Question5();
            }
            catch (FormatException error5)
            {
                Console.WriteLine("Exception caught.  This isn't Javascript!  You need to type in true or false.  Not truthy or falsey.");
                Console.WriteLine(error5);
            }
            catch (Exception error5All)
            {
                Console.WriteLine("General Exception Caught.  I don't know what you typed but you broke it.  Thanks!");
                Console.WriteLine(error5All);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are all done!");
                Console.ReadLine();
            }
            //This is the final counter of correct answer quessed.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You have gotten {counter} correct.");
            Console.ReadLine();
        }

        static string Question1() //any answer.
        {
            Console.WriteLine("Does Carlos have a Mac or Windows laptop?");
            string input1 = Console.ReadLine();
            string input1Caps = input1.ToUpper();
            if (input1Caps == "MAC")
            {
                Console.WriteLine("Correct. Carlos uses a Mac with BootCamp to run Windows.");
                counter++;
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
                counter++;
            }
            else
                Console.WriteLine("Sorry.  Carlos actually has 1 dog & 1 cat.  They snuggle together.");
            Console.ReadLine();
            return input2Number;
        }

        static bool Question3() //true or false
        {
            Console.WriteLine("Carlos enjoys playing Pokemon Go.  \"true\" or \"false\".");
            string input3 = Console.ReadLine();  //Take in user input as string
            string input3Lower = input3.ToLower();  //convert user answer to lowercase
            bool input3Bool = Boolean.Parse(input3Lower); //conver that lowercase answer to true or false
            if (input3Bool == true)
            {
                Console.WriteLine("Correct.  He is a level 36 Poke-Master and will one day catch them all!");
                counter++;
            }
            else //if typed false, this will display.
                Console.WriteLine("Sorry.  He is serious about catching them all!  POKEMON!");
            Console.ReadLine();
            return input3Bool;
        }

        //With more time I could of made this into an array of strings to use a try-catch block for question 4.
        static string Question4()  
        {
            Console.WriteLine("Pick the usual morning drink of choice for Carlos?  Type 1, 2, or 3.");
            Console.WriteLine("1) Coffee!");
            Console.WriteLine("2) Tea!");
            Console.WriteLine("3) Red-Bull");
            Console.WriteLine("4) Coke Zero");
            Console.WriteLine("5) Something else");
            string input4 = Console.ReadLine(); //takes in user input as a string
            if (input4 == "2")
            {
                Console.WriteLine("Correct.  He prefers a gentler drug to wake him up.");
                counter++;
            }
            else
                Console.WriteLine("Sorry.  He prefers a gentler drug to wake him up.");
            Console.ReadLine();
            return input4;
        }

        static bool Question5()  //true or false
        {
            Console.WriteLine("Carlos has lived in New York City?  \"true\" or \"false\" ");
            string input5 = Console.ReadLine();  //Take in user input as string
            string input5Lower = input5.ToLower();  //convert user answer to lowercase
            bool input5Bool = Boolean.Parse(input5Lower); //conver that lowercase answer to true or false
            if (input5Bool == true)
            {
                Console.WriteLine("Correct.  He lived near the Brooklyn Bridge.");
                counter++;
            }
            else //if typed false, this will display.
                Console.WriteLine("Sorry.  He live in Brooklyn for 3 years.");
            Console.ReadLine();
            return input5Bool;
        }
    }
}
