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

        public static Pet CreatePet()
        {
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

            return new Pet(petType, name);

        }



        public static void simulation(Pet pet)
        {

            Console.WriteLine("Your New" + pet.type + " Is named " + pet.name);
            Console.WriteLine("\n Commands: \nq:Quit\nx:Reset\nf:Feed\n:Play\nr:Rest\nc:check stats");
            bool quit = false;

            while (quit == false)
            {
                // case statement to choose commands





                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(false).KeyChar)
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
                   
                }
               
                if (pet.Health == 0)
                {
                    Console.WriteLine("Your Pet Didn't make it :(");
                    quit = true;
                }

            }


            static void showPetStats(Pet pet)
            {
                Console.WriteLine("\n\nHealth:" + pet.Health + "\nHunger" + pet.Hunger + "\nHappiness:" + pet.Happiness);
            }






        }
    }
}