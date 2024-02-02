﻿using System;
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
            if (Happiness > 3)
            {
                Hunger = hunger - 4;
                health ++;
                Console.WriteLine("You fed your pet ");
            }
            else {
                Console.WriteLine("Your pet is too unhappy, it refused to eat");
            }
        }

        public void Play() {
            bool canplay = true;
            if (Hunger >=8)
            {
                canplay = false;
                Console.WriteLine("Your pet is too hungry to play");
            }
            if (health <=3) { 
            canplay=false;
           Console.WriteLine("Your pet is too unhealthy to play");
            }
            if (canplay == true) {
                Happiness = happiness + 4;
                Hunger ++;
                Console.WriteLine("You played with your pet");
            }

        }

        public void Rest() {
            Health = health + 4;
            Happiness = happiness - 1;
            Console.WriteLine("You let your pet rest");
        }

        public void TimeTick() {
            Hunger = hunger + 2;
            Happiness = happiness - 1;

            if (Hunger >= 7) {
                Health--;
            }
            if (Happiness < 2) {
                Health--;
            }
            
        }
        

    }
}
