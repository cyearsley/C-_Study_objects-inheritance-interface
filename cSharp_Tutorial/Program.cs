using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsClasses;
using Inheritance;
using Interface;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObjectsClassesTutorial test = new ObjectsClasses.ObjectsClassesTutorial();
            //InheritanceTutorial test = new InheritanceTutorial();
            InterfaceTutorial test = new InterfaceTutorial();
            while (test.ContinueFlag) { test.run(); }

            Console.WriteLine("Exiting...\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
