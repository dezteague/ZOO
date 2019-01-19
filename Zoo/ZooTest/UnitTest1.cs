using System;
using Xunit;
using Zoo;
using Zoo.Classes;
using Zoo.Interfaces;

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
        public void TigerLives()
        {
            Tiger tiger = new Tiger();
            string warm = tiger.Live();
            Assert.Equal("I live in warm climates", warm);
        }

        [Fact]
        public void TigerProducesCubs()
        {
            Tiger tiger = new Tiger();
            string cubs = tiger.Cubs();
            Assert.Equal("My cubs are the cutest", cubs);
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
        public void BearLives()
        {
            Bear bear = new Bear();
            string forest = bear.Live();
            Assert.Equal("I live in dense forest", forest);
        }

        [Fact]
        public void BearProducesCubs()
        {
            Bear bear = new Bear();
            string cubs = bear.Cubs();
            Assert.Equal("My babies are called cubs!", cubs);
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
        public void OrangutanLives()
        {
            Orangutan orangutan = new Orangutan();
            string islands = orangutan.Live();
            Assert.Equal("I live in Borneo and Sumatra", islands);
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
        public void OwlLives()
        {
            Owl owl = new Owl();
            string nest = owl.Live();
            Assert.Equal("I live in a nest", nest);
        }

        [Fact]
        public void OwlCanFly()
        {
            Owl owl = new Owl();
            string flies = owl.Fly();
            Assert.Equal("I'm notcturnal, I fly through the night!", flies);
        }

        [Fact]
        public void OwlProducesEggs()
        {
            Owl owl = new Owl();
            string eggs = owl.Eggs();
            Assert.Equal("My babies hatch from eggs", eggs);
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

        [Fact]
        public void GoldfishLives()
        {
            GoldFish goldFish = new GoldFish();
            string bowl = goldFish.Live();
            Assert.Equal("I live in my fish bowl :(", bowl);
        }

        [Fact]
        public void GoldfishProducesEggs()
        {
            GoldFish goldFish = new GoldFish();
            string eggs = goldFish.Eggs();
            Assert.Equal("I lay soft eggs", eggs);
        }

        [Fact]
        public void TigerIsAnimal()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger is Animal);
        }

        [Fact]
        public void BearIsAnimal()
        {
            Bear bear = new Bear();
            Assert.True(bear is Animal);
        }

        [Fact]
        public void BearIsMammal()
        {
            Bear bear = new Bear();
            Assert.True(bear is Mammal);
        }


    }
}
