using Breed.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breed.Controller
{
    internal class Controller
    {
        public void Ctrl()
        {
            // Creating instances of different animal types and storing them in variables
            // of a common base class or interface (Polymorphism).
            Chicken chick1 = new Chicken("EggLayer", "Chicken", "Bob", 2, 2, "Female", "Blue", true);
            Dog dog1 = new Dog("Mating", "Dog", "Otto", 1, 4, "Male", "Long", true);
            Rabbit rabbit1 = new Rabbit("Mating", "Rabbit", "John", 6, 4, "Male", "short", true);

            // Calling the SpecialAnimalTrade method on different animal objects
            // that implement various animal interfaces.
            dog1.SpecialAnimalTrade();
            chick1.SpecialAnimalTrade();
            rabbit1.SpecialAnimalTrade();

            // Writing the details of different types of animals to the GUI.
            View.Gui.WriteAnimals(chick1, dog1, rabbit1);   
        }
    }
}
