﻿using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace PetSimulator
{
    public class Program
    {
        private static void Main(string[] args)


        {
            Console.WriteLine("Welcome to Pet Simulator!");

            Pet newPet = CreatePet();
            simulation(newPet);


        }
        // creating pet
        public static Pet CreatePet()
        {
            string petType = " ";
            bool typeSelected = false;
            while (typeSelected == false)
            {
                Console.WriteLine("\nChoose a type of Pet ");
                Console.WriteLine(" 1) Dog\n 2) Cat\n 3) Rabbit");
                // switch statement to choose pet
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        // clear the console to clean up UI
                        Console.Clear();
                        petType = "Dog";
                        Console.WriteLine("\nYour new pet will be a Dog!");

                        typeSelected = true; break;


                    case '2':
                        petType = "Cat";
                        Console.Clear();
                        Console.WriteLine("\nYour new pet will be a Cat!");

                        typeSelected = true; break;


                    case '3':
                        petType = "Rabbit";
                        Console.Clear();
                        Console.WriteLine("\nYour new pet will be a Rabbit!");

                        typeSelected = true; break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Selection");
                        break;


                }


            }


            Console.WriteLine("What Will You Name Your Pet?");
            string name = "";

            name = Console.ReadLine();
            //return for use later in other functions
            return new Pet(petType, name);

        }


        // simulation function 
        public static void simulation(Pet pet)
        {

            Console.WriteLine("Your New " + pet.type + " Is named " + pet.name);
            Console.WriteLine("\n Commands: \nq:Quit\nf:Feed\np:Play\nr:Rest\nc:check stats");
            bool quit = false;

            while (quit == false)
            {
                // case statement to choose commands

               
                    switch (Console.ReadKey(false).KeyChar)
                    {
                        case 'q':

                            quit = true;


                            break;

                        
                        case 'f':
                         
                            pet.Feed();

                            Console.WriteLine("You fed with" + pet.name + "\nHunger decresed, health increased slightly");
                            break;
                        case 'p':
                            pet.Play();
                        Console.WriteLine("You Played with" + pet.name + "\nHappiness incresed, hunger increased slightly");

                            break;
                        case 'r':
                            pet.Rest();
                            Console.WriteLine("You let"+pet.name+"rest\n Health increased, happiness decreased slightly");


                            break;
                        case 'c':

                            showPetStats(pet);

                            break;


                        default:

                            Console.WriteLine("Invalid command");
                            break;


                    }

                // notify user of critical status
                if (pet.Hunger> 7)
                {
                    Console.WriteLine(pet.name + "is very hungry!");
                   
                }
                if (pet.Happiness < 3)
                {
                    Console.WriteLine(pet.name + "is unhappy!");
                    
                }

                if (pet.Health < 3)
                {
                    Console.WriteLine(pet.name+"is unhealthy!");
                  
                }

                if (pet.Health == 0)
                {
                    Console.WriteLine(pet.name+" Didn't make it :(");
                    quit = true;
                }

            }

            // function to display pet status
            static void showPetStats(Pet pet)
            {
                Console.WriteLine("\n\nHealth:" + pet.Health + "\nHunger" + pet.Hunger + "\nHappiness:" + pet.Happiness);
            }






        }
    }
}