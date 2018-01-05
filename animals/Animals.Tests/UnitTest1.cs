using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalTest
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalTest()
        {
            _animal = new Animal();
            _dog = new Dog();
            
        }
        [Fact]
        public void NameIsCorrect()
        {
            _animal.Name = "Doug";
            Assert.Equal(_animal.Name, "Doug");
        }

        [Fact]
        public void SpeciesIsCorrect()
        {
            _dog.Species = "Dog";
            Assert.Equal(_dog.Species, "Dog");
        }

        [Fact]
        public void WalkMethodCorrect()
        {
            
            Assert.Equal(_dog.Walk(), "Walking on a leash");
            Assert.Equal(_animal.Walk(), "Roaming Free");
        }

        [Fact]
        public void IsInstanceOf()
        {
            var expectedDog = _dog.GetType();
            var expectedAnimal = _animal.GetType();
            Assert.IsType(expectedDog, new Dog());
            Assert.IsType(expectedAnimal, new Animal());
        }
    }
}
