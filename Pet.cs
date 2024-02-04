using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimulator
{
    public class Pet
    {  // get and set functions limit range of properties
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
        // constructor method
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
         // TimeTick is called to simulate passage of time after each action
            TimeTick();
           
            
            
        }

        public void Play() {
            bool canplay = true;
            if (Hunger >=8)
            {
                canplay = false;
                Console.WriteLine(name+" is too hungry to play");

            }

            // pet will not play if too unhealth or too hungry
            if (Health <=3) { 
            canplay=false;
             Console.WriteLine(name+" is too unhappy to play");
            }
            if (canplay == true) {
                Happiness = Happiness + 4;
                Hunger ++;
                

            }
            TimeTick();
        }

        public void Rest() {
            Health = Health + 4;
            Happiness = happiness - 1;
            TimeTick();
            
        }

        public void TimeTick() {
           // decrease hunger and happiness after each action to simulate time passage
            Hunger = Hunger + 2;
            Happiness = Happiness - 1;

            // decrease health if pet is very hungry
            if (Hunger >= 8) {
                Health--;
            }
            // decrease health if pet is very unhappy
            if (Happiness < 2) {
                Health--;
            }
            
        }
        

    }
}
