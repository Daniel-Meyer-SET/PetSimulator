
using System.Security.Cryptography.X509Certificates;
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
                        Console.WriteLine("\nInvalid Selection");
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

            Console.WriteLine("\nYour New " + pet.type + " Is named " + pet.name);
            bool quit = false;

            while (quit == false)
            {

                
               
                Console.WriteLine("\nCommands: \nq:Quit\nf:Feed\np:Play\nr:Rest\nc:check stats");
                // case statement to choose commands


                switch (Console.ReadKey(false).KeyChar)
                    {
                        case 'q':
                        Console.WriteLine("Goodbye");
                            quit = true;


                            break;

                        
                        case 'f':
                         
                            pet.Feed();

                            Console.WriteLine("\nYou fed " + pet.name + "\nHunger decresed, health increased slightly");
                            break;
                        case 'p':
                            pet.Play();
                        Console.WriteLine("\nYou Played with " + pet.name + "\nHappiness incresed, hunger increased slightly");

                            break;
                        case 'r':
                            pet.Rest();
                            Console.WriteLine("\nYou let "+pet.name+" rest\n Health increased, happiness decreased slightly");


                            break;
                        case 'c':
                        Console.WriteLine(":Check Stats");
                        showPetStats(pet);
                        
                            break;


                        default:
                            // default case will simulate passage of time by triggering time tick event with no other actions
                            Console.WriteLine("\nyou waited for 1 hour");
                            pet.TimeTick();
                            break;


                    }

                // notify user of critical status
                if (pet.Hunger> 7)
                {
                    Console.WriteLine("\n"+pet.name + " is very hungry!");
                   
                }
                if (pet.Happiness < 3)
                {
                    Console.WriteLine("\n"+pet.name + " is unhappy!");
                    
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