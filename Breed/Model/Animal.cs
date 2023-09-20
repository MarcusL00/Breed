using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breed.Model
{
    // The Animal class represents a generic animal with basic properties.
    internal class Animal
    {
        // Fields to store information about the animal.
        protected string repoductionType;
        protected string species;
        protected string name;
        protected int age;
        protected int amountOfLegs;
        protected string gender;

        // Properties to access and set information about the animal.
        protected string RepoductionType
        {
            get => repoductionType;
            set => repoductionType = value;
        }
        protected string Species
        {
            get => species;
            set => species = value;
        }
        protected string Name
        {
            get => name;
            set => name = value;
        }
        protected int Age
        {
            get => age;
            set => age = value;
        }
        protected int AmountOfLegs
        {
            get => amountOfLegs;
            set => amountOfLegs = value;
        }
        protected string Gender
        {
            get => gender;
            set => gender = value;
        }
        // Constructor to initialize an Animal object with provided properties.
        internal Animal(string repoductionType, string species, string name, int age, int amountOfLegs, string gender)
        {
            RepoductionType = repoductionType;
            Species = species;
            Name = name;
            Age = age;
            AmountOfLegs = amountOfLegs;
            Gender = gender;

        }
        // Override of the ToString() method to provide a custom string representation of an Animal object.
        public override string ToString()
        {
            return ($"RepoductionType: {repoductionType}" +
                $"Species: {species}" +
                $"Name: {name}" +
                $"Age: {age}" +
                $"Amount of legs: {amountOfLegs}" +
                $"Gender: {gender}");

        }
    }
}