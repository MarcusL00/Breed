using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breed.View
{
    internal class Gui
    {
        // WriteAnimals method displays information about animals in the console.
        // It takes an array of Model.Animal objects as parameters and iterates through them,
        // calling the ToString method for each animal and printing the details to the console.
        // After displaying the information, it waits for a key press to allow the user to read the output
        public static void WriteAnimals(params Model.Animal[] animals) 
        {
            foreach (var animal in animals) 
            {
                Console.WriteLine(animal.ToString());
            }
            Console.ReadKey();
        }
    }
}
