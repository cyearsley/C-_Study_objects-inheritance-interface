using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class InterfaceTutorial
    {
        private bool continueFlag;
        public bool ContinueFlag
        {
            get { return this.continueFlag; }
            set { this.continueFlag = value; }
        }

        public InterfaceTutorial()
        {
            this.ContinueFlag = true;
        }

        public void run()
        {
            this.ContinueFlag = false;

            Animal dog = new Dog();
            Animal cow = new Cow();
            Animal bird = new Bird();

            List<Animal> animalList = new List<Animal>();
            animalList.Add(dog);
            animalList.Add(cow);
            animalList.Add(bird);

            for (int i = 0; i < animalList.Count(); i++)
            {
                Console.WriteLine("The {0} makes the sound: {1}", animalList[i].getName().ToString(), animalList[i].makeSound());
            }
        }

        abstract class Animal : IMakeSound
        {
            public abstract String makeSound();
            public abstract String getName();
        }

        public interface IMakeSound
        {
            String makeSound();
            String getName();
        }

        class Dog : Animal, IMakeSound
        {
            public override String makeSound()
            {
                return ("The dog says: *bark* *bark* *bark*");
            }

            public override string getName()
            {
                return "Dog";
            }
        }

        class Cow : Animal, IMakeSound
        {
            public override String makeSound()
            {
                return ("The cow says: MOOOOOOO");
            }

            public override string getName()
            {
                return "Cow";
            }
        }

        class Bird : Animal, IMakeSound
        {
            public override String makeSound()
            {
                return ("The bird says: *tweet* *tweet* *tweet*");
            }

            public override string getName()
            {
                return "Bird";
            }
        }
    }
}
