using System;
using Xunit;
using Zoo;
using Zoo.Classes;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void TigerMakesSound()
        {
            Tiger tiger = new Tiger();
            string roar = tiger.Sound();
            Assert.Equal("Roarrr", roar);
        }

        [Fact]
        public void TigerEats()
        {
            Tiger tiger = new Tiger();
            string meat = tiger.Eat();
            Assert.Equal("I eat my meat rare", meat);
        }

        [Fact]
        public void BearMakesSound()
        {
            Bear bear = new Bear();
            string growl = bear.Sound();
            Assert.Equal("Growl!", growl);
        }

        [Fact]
        public void BearEats()
        {
            Bear bear = new Bear();
            string honey = bear.Eat();
            Assert.Equal("Honey comb please!", honey);
        }

        [Fact]
        public void OrangutanMakesSound()
        {
            Orangutan orangutan = new Orangutan();
            string ohah = orangutan.Sound();
            Assert.Equal("Ooh Oh Ah Aah", ohah);
        }

        [Fact]
        public void OrangutanEats()
        {
            Orangutan orangutan = new Orangutan();
            string banana = orangutan.Eat();
            Assert.Equal("Bananas please!", banana);
        }

        [Fact]
        public void OwlMakesSound()
        {
            Owl owl = new Owl();
            string hoot = owl.Sound();
            Assert.Equal("Twoo Twoo", hoot);
        }

        [Fact]
        public void OwlEats()
        {
            Owl owl = new Owl();
            string mice = owl.Eat();
            Assert.Equal("Mice on the menu?", mice);
        }

        [Fact]
        public void GoldfishMakesSound()
        {
            GoldFish goldFish = new GoldFish();
            string bloop = goldFish.Sound();
            Assert.Equal("Bloop, bloop", bloop);
        }

        [Fact]
        public void GoldfishEats()
        {
            GoldFish goldFish = new GoldFish();
            string pellets = goldFish.Eat();
            Assert.Equal("Feed me pellets!", pellets);
        }
    }
}
