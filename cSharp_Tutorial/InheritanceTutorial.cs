using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class InheritanceTutorial
    {
        private bool continueFlag;
        public bool ContinueFlag
        {
            get
            {
                return this.continueFlag;
            }
            set
            {
                this.continueFlag = value;
            }
        }
        public InheritanceTutorial ()
        {
            this.ContinueFlag = true;
        }
        public bool run()
        {
            this.ContinueFlag = false;

            Dog dog = new Inheritance.Dog();
            Duck duck = new Inheritance.Duck();
            DillPickle dp = new DillPickle();

            List<Animal> animalList = new List<Animal>();
            animalList.Add(dog);
            animalList.Add(duck);
            animalList.Add(dp);

            for (int i = 0; i < animalList.Count(); i++)
            {
                // Check to see if the animal is a dill pickle...
                if (animalList[i] is DillPickle)
                {
                    Console.Write("The pickle still goes... ");
                }
                animalList[i].eat();
            }

            dog.bark();
            duck.quack();
            dp.eat();

            return false;
        }
    }

    class Animal
    {
        public void eat()
        {
            Console.WriteLine("*Chomp* *Chomp* *Chomp*, yummmm....");
        }
    }

    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("*bark* *bark*");
        }
    }

    class Duck : Animal
    {
        public void quack()
        {
            Console.WriteLine("*quack* *quack* *quack*");
        }
    }

    class DillPickle : Animal
    {
        new public void eat()
        {
            Console.WriteLine("WAHT, pickles don't eat...");
        }
    }
}
