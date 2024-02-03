using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimulator
{
    public class Pet
    {  //
        private int health;
       public int Health
        {
            set { 
               
                if(value >=0 && value <= 10) { this.health = value; }
                
            }
            get { 
                return health;
            }
        }
        private int hunger;
        public  int Hunger
        {
            set
            {

                if (value >= 0 && value <= 10) { this.hunger = value; }

            }
            get
            {
                return hunger;
            }
        }
        private int happiness;
       public int Happiness
        {
            set
            {

                if (value >= 0 && value <= 10) { happiness = value; }

            }
            get
            {
                return happiness;
            }
        }
       public string name { get; set; }
       public string type { get; set; }

        public Pet(string initType, string initName) {
            Health = 10;
            Hunger = 0;
            Happiness =10;
            name = initName;
            type = initType;
        }
        public void Feed() {
          
                Hunger = hunger - 4;
                Health ++;
            TimeTick();
            Console.WriteLine("You fed your pet ");
            
            
        }

        public void Play() {
            bool canplay = true;
            if (Hunger >=8)
            {
                canplay = false;
                TimeTick();
                Console.WriteLine("Your pet is too hungry to play");
            }
            if (Health <=3) { 
            canplay=false;
           Console.WriteLine("Your pet is too unhealthy to play");
            }
            if (canplay == true) {
                Happiness = Happiness + 4;
                Hunger ++;
                TimeTick();
                Console.WriteLine("You played with your pet");
            }

        }

        public void Rest() {
            Health = Health + 4;
            Happiness = happiness - 1;
            TimeTick();
            Console.WriteLine("You let your pet rest");
        }

        public void TimeTick() {
            Hunger = Hunger + 2;
            Happiness = Happiness - 1;

            if (Hunger >= 7) {
                Health--;
            }
            if (Happiness < 2) {
                Health--;
            }
            
        }
        

    }
}
