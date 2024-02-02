﻿using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace PetSimulator {
    public class Program
    {
        private static void Main(string[] args)


        {
            Console.WriteLine("Welcome to Pet Simulator!");
           
          Pet newPet = CreatePet();
            simulation(newPet);

        
        }

            public static Pet CreatePet (){
            string petType = " ";
            bool typeSelected = false;
            while (typeSelected == false)
            {
                Console.WriteLine("\nChoose a type of Pet ");
                Console.WriteLine(" 1) Dog\n 2) Cat\n 3) Rabbit");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
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

                return new Pet(petType,name);
 
            }

       

        public static async void simulation(Pet pet) {

            Console.WriteLine("Your New"+pet.type+" Is named "+pet.name);
            Console.WriteLine("\n Commands: \nq:Quit\nx:Reset\nf:Feed\np:Play\nr:Rest");
            bool quit = false;
            var eventTimer = new System.Timers.Timer();
            eventTimer.Start();
            while (pet.Health > 0 || quit == false)
            {
                // case statement to choose commands


                timerCall(pet);
                Console.WriteLine("Health:"+pet.Health,"\nHunger"+pet.Hunger,"Happiness:"+pet.Happiness);

                switch (Console.ReadKey().KeyChar)
                {
                    case 'q':
                       
                        quit = true;
                        

                    break;


                    case 'x':

                        quit = true;
                        CreatePet();
                        
                         break;


                    case 'f':
                        pet.Feed();
                       

                        break;
                    case 'p':
                        pet.Play();


                        break;
                    case 'r':
                        pet.Rest();


                        break;


                    default:

                        Console.WriteLine("Invalid command");
                        break;


                }
            }
            
        
        }

        static async  void timerCall(Pet pet)
        {
            await Task.Delay(10000);
            pet.TimeTick();
        }

        


            
        
    }
}