using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsClasses
{
    class ObjectsClassesTutorial
    {
        private String userInput;
        public String UserInput
        {
            get { return this.userInput; }
            set { this.userInput = value; }
        }

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

        public ObjectsClassesTutorial ()
        {
            this.ContinueFlag = true;
        }

        public bool run()
        {
            Console.WriteLine("\n\n======================");
            Console.WriteLine("a) Do something\nb) Do something\nx) Exit");
            Console.WriteLine("======================");

            UserInput = Console.ReadLine();

            if (UserInput.ToUpper() == "x".ToUpper())
            {
                ContinueFlag = false;
            }
            else
            {
                ContinueFlag = true;
            }

            return ContinueFlag;
        }
    }
}
