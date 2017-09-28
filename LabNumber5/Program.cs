using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an application that simulates dice rolling
            //ask the user to enter the number of sides for a pair of dice 
            //prompt the user to roll the dice 
            //roll the two dice and display the results of each dice roll
            //ask the user if they would like to roll the dice again



            Console.WriteLine("Hi! Welcome to the GC Casino! Would you like to roll the dice?");
            string Response = Console.ReadLine();
            bool Continue = true;
            bool RollAgain = true;


            if (Response == "yes" || Response == "Yes" || Response == "y" || Response == "Y")
            {
                Console.WriteLine("Great! Let's play!");
            }
            else
            {
                Console.WriteLine("No fun! See ya later!");
                return;
            }

            while (RollAgain==true)

            {
                Console.WriteLine("How many sides should the dice have?");

                int DiceNumber = int.Parse(Console.ReadLine());

                GetRandom(1, DiceNumber);

                Console.WriteLine("Would you like to roll again, yes or no?");
                string userResponse = (Console.ReadLine());


                if (userResponse == "Yes" || userResponse == "yes" || userResponse == "y" || userResponse == "Y")
                {
                    RollAgain = true;
                }
                else if (userResponse == "No" || userResponse == "no" || userResponse == "N" || userResponse == "n")
                {
                    RollAgain = false;
                }
                else
                {
                    RollAgain = false;
                }
            }    

                    Continue = false;               
        }

        static void GetRandom(int Min, int Max)
        {
            Random rnd = new Random();
            int Number1 = rnd.Next(Min, Max);
            int Number2 = rnd.Next(Min, Max);

            Console.WriteLine("Your first roll is number:" + " " + Number1);
            Console.WriteLine("Your second roll is number:" + " " + Number2);
        }

    }
}
