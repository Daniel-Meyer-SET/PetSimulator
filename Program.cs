public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Pet Simulator!\n");
        Console.WriteLine("\nChoose a type of Pet ");
        Console.WriteLine(" 1) Dog\n 2) Cat\n \n  3) Rabbit");

      

        string petType = " ";
        bool typeSelected = false;
        while (typeSelected == false)
        {
            switch (Console.ReadKey().KeyChar) { 
            case '1':
                    petType = "Dog";
                    Console.WriteLine("\nYour new pet will be a Dog!");
                    typeSelected = true; break;
                    
            
            case '2':
                    petType = "Cat";
                    Console.WriteLine("\nYour new pet will be a Cat!");
                    typeSelected = true; break;
                    
            
            case '3':
                    petType = "Rabbit";
                    Console.WriteLine("\nYour new pet will be a Rabbit!");
                    typeSelected = true; break;
                   

            default:
            Console.WriteLine("Invalid Selection");
            break;

            
            }

           
        }
    }
}