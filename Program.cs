using System.Security.Cryptography.X509Certificates;

namespace PetSimulator {
    public class Program
    {
        private static void Main(string[] args)


        {
            Console.WriteLine("Welcome to Pet Simulator!");
           
          Pet newPet = createPet();
            simulation(newPet);

        
        }

            public static Pet createPet (){
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

       

        public static void simulation(Pet pet) {

            Console.WriteLine("Your New"+pet.type+" Is named "+pet.name);
            Console.WriteLine("\n Commands: \nQ:Quit\nX:Reset\nF:Feed\nP:Play\nR:Rest");
            bool quit = false;
            while(pet.health > 0 || quit == false)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'Q':
                       
                        quit = true;
                        

                    break;


                    case 'R':


                        createPet();

                         break;


                    case 'F':
                        pet.feed();
                       

                        break;


                    default:
                       
                        break;


                }
            }

        
        }




            
        
    }
}