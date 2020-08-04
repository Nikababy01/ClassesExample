using ClassesExample.Animal;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            
            chicken.Peck("corn");
            
            var bob = new Chicken("Bob");
            
            bob.Peck("watermelon");
            
        }
    }
}
