public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Pet Simulator!\n");
       
      

        string petType = " ";
        bool typeSelected = false;
        while (typeSelected == false)
        {
            Console.WriteLine("\nChoose a type of Pet ");
            Console.WriteLine(" 1) Dog\n 2) Cat\n \n  3) Rabbit");

            switch (Console.ReadKey().KeyChar) { 
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
    }
}