using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animal
{
    class Chicken
    {

        //property
        public string Name { get; set; }

        //Field
        private bool _isHungry = true;

        //default constructor
        public Chicken(string name)
        {
            Name = name;
            Console.WriteLine("Chicken got instantiated...");
        }
        //method (signature = accessibility modifier -> return type -> Nme -> Parameters
        public void Peck(string typeOfFood)
        {
            if (_isHungry)
            {
                Console.WriteLine($"{Name} pecks hungryily at the {typeOfFood}.");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }
    }
}
