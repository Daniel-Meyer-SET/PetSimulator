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

                if (value >= 0 && value <= 10) { this.health = value; }
                else if (value < 0) { 
              
                    this.health = 0;
                }
                else if (value > 10) {
                   
                    this.health = 10;
                }
                
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
                else if (value < 0)
                {
                   
                    this.hunger = 0;
                }
                else if (value > 10)
                {
                    
                    this.hunger = 10;
                }


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
                else if (value < 0)
                {
                   
                    this.happiness = 0;
                }
                else if (value > 10)
                {
                   
                    this.happiness= 10;
                }


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
            // TimeTick is called to simulate passage of time after each action
            TimeTick();
            Hunger = Hunger - 4;
            Health = Health +2;        
        
        }

        public void Play() {
            bool canplay = true;
            TimeTick();
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
                Hunger++;
                

            }
           
        }

        public void Rest() {
            TimeTick();
            Health = Health + 4;
            Happiness--;
           
            
        }

        public void TimeTick() {
           // decrease hunger and happiness after each action to simulate time passage
            Hunger = Hunger + 2;
            Happiness --;

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
