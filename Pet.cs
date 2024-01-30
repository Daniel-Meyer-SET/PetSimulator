using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimulator
{
    public class Pet
    {  //
       private int health { get ; set; }
       private  int hunger { get; set; }
       private int happiness { get; set; }
       private string name { get; set; }
       private string type { get; set; }

        public Pet(string initType, string initName) {
            health = 10;
            hunger = 0;
            happiness =10;
            name = initName;
            type = initType;
        }
        public void feed() {
            hunger = hunger - 4;
            health = health +1;
        }

        public void play() {
            happiness = happiness +4;
            hunger = hunger + 2;
        }

        public void rest() {
            health = health + 4;
            happiness = happiness - 1;
        }

        public void timeTick() {
            hunger = hunger + 3;
            happiness = happiness - 1;
        }

    }
}
