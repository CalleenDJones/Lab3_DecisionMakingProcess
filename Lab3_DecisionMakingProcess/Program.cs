using System;

namespace Lab3_DecisionMakingProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string Name;
            int Num1;

            //Salutation and prompt user for their name
            Console.WriteLine("Greetings! Please enter your first name.");
            Name = (Console.ReadLine());
            Console.Write("Thank you, " + Name +". ");
            Console.WriteLine("Now we will play a numbers game.");
            Console.WriteLine("Please enter a whole number ranging from 1 to 100");
            Num1 = Convert.ToInt32(Console.ReadLine());

            //Validate number is between 1 - 100
            if( Num1 > 0 && Num1 <= 100)
            {
                Console.WriteLine("Congratulations, " + Name + ", you have entered a subtable value");
            }
            else
            {
                Console.WriteLine("Sorry, " + Name + ", that number isn't between 1 and 100. Please try again.");
                Console.WriteLine("Please enter a whole number ranging from 1 to 100");
                Num1 = Convert.ToInt32(Console.ReadLine());
            }

            //Determine if number is ODD and greater than 60
            if ((Num1 % 2 != 0) && (Num1 >= 60))
            {
                Console.WriteLine(Name + ", " + Num1 +", is ODD");
            }


            else if ((Num1 % 2 != 0) && (Num1 < 60))
            {
                Console.WriteLine(Num1 + ", is ODD");
            }

            //Determine if number is ODD and less than 60
            else if  ((Num1 >= 2) && (Num1 <= 25))
            {
                Console.WriteLine(Name + ", this is an EVEN number and less than 25.");
            }

            //Determine if number is EVEN and between 26 - 60
            else if ((Num1 >= 26) && (Num1 <= 60))
            {
                Console.WriteLine(Name + ", this is an EVEN number.");
            }

            //Determine if number is EVEN and greater than 60
            else if ((Num1 >= 60))
            {
                Console.WriteLine(Name + ", this is an EVEN number and greater than 60.");
            }

            //Thank user
            Console.WriteLine("Thank you for your participation, " + Name + "!");
            Console.WriteLine("Press enter to exit program.");
            Console.ReadKey(); 
        }
    }
}
