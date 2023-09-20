using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breed.Model
{
    internal class Chicken : Animal, IChicken
    {
        // Field to store additional attrubutes of a Chicken.
        protected string eggColor;
        protected bool hasFeathers;

        // Properties to access the Chicken's Egg color and has feathers status.
        protected string EggColor
        {
            get => eggColor;
            set => eggColor = value;
        }

        protected bool HasFeathers
        {
            get => hasFeathers;
            set => hasFeathers = value;
        }
        // Constructor to initialize a Chicken object.
        internal Chicken(string repoductionType, string species, string name, int age, int amountOfLegs, string gender, string eggColor, bool hasFeathers) : base(repoductionType, species, name, age, amountOfLegs, gender)
        {
            this.EggColor = eggColor;
            this.HasFeathers = hasFeathers;
        }
        // Override of the ToString() method to provide a custom string representation of a Chicken object.
        public override string ToString()
        {
            return $"RepoductionType: {repoductionType}, Species: {species}, Name: {name}, Age: {age}, Amount of legs: {amountOfLegs}, Gender: {gender}, Egg color: {eggColor}, Has Feathers: {hasFeathers} ";
        }
        // Implementation of the SpecialAnimalTrade method as required by the IChicken interface.
        public void SpecialAnimalTrade()
        {
            Console.WriteLine("the chicken has laid eggs");
        }


    }
}
