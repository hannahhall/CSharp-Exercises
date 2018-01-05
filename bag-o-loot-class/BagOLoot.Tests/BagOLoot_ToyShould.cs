using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyShould
    {
        private ToyShould _toy;

        public ToyShould()
        {
            _toy = new ToyShould();
        }

        public void AddToyToDatabase()
        {
            bool result = _toy.AddToy("Legos");
            Assert.True(result);
        }

        public void AddToyToBag()
        {
            bool result = _toy.AddToyToBag(1, 2);
            Assert.True(result);
        }
    }
}