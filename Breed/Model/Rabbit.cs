using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Breed.Model
{
    // The Rabbit class represents a type of animal that inherits from Animal and implements IRabbit interface.
    internal class Rabbit : Animal, IRabbit
    {
        // Fields to store additional attributes of a Rabbit.
        protected string hairType;
        protected bool hasFur;

        // Properties to access the Rabbit's hair type and fur status.
        protected string HairType
        {
            get => hairType;
            set => hairType = value;
        }

        protected bool HasFur
        {
            get => hasFur;
            set => hasFur = value;
        }
        // Constructor to initialize a Rabbit object.
        internal Rabbit(string repoductionType, string species, string name, int age, int amountOfLegs, string gender, string hairType, bool hasFur) : base(repoductionType, species, name, age, amountOfLegs, gender)
        {
            this.HairType = hairType;
            this.HasFur = hasFur;
        }

        // Override of the ToString() method to provide a custom string representation of a Rabbit object.
        public override string ToString()
        {
            return $"RepoductionType: {repoductionType}, Species: {species}, Name: {name}, Age: {age}, Amount of legs: {amountOfLegs}, Gender: {gender}, HairType: {hairType}, Has Fur: {hasFur} ";
        }
        // Implementation of the SpecialAnimalTrade method as required by the IRabbit interface.
        public void SpecialAnimalTrade()
        {
            Console.WriteLine("the rabbit has long ears");
        }
    }
}
