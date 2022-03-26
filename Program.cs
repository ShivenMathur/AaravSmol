using System;

namespace AaravIsSmol
{
    class Program
    {

        public void theEnd()
        {

            Console.WriteLine("What is Aarav's age?: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {

                Console.WriteLine("Ok, I accept that Aarav isnt that smol. But he is smol anyways, hehe.");
                Console.WriteLine("bye, have a great time");
                Console.ReadLine();

            }

            else
            {

                Console.WriteLine("See he is smol, " + age + " year old people are smol, hes not even 18. End of discussion.");
                Console.WriteLine("bye, have a great time");
                Console.ReadLine();

            }



        }


        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Hello, today I am going to prove that Aarav is smol.");

            Console.Write("First I wanna know your name, so whats your name?: ");
            string username = Console.ReadLine();
            Console.WriteLine("Good to meet you " + username + "!");

            Console.WriteLine("Lets start now,");

            Console.Write("Do you know Aarav?[yes | no]: ");
            string knowAarav = Console.ReadLine();

            if (knowAarav == "yes")
            {

                Console.WriteLine("You are a good boy.");
                program.theEnd();

            }

            else if (knowAarav == "no")
            {

                Console.WriteLine("Why are you even here then?, whatever.");
                program.theEnd();
            }

            else
            {

                Console.WriteLine("Aarav is smol, you are mad. Enter yes or no, why did you enter " + knowAarav + "?!!!");
            }






        }
    }
}
