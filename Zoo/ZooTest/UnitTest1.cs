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
        public void BearMakesSound()
        {
            Bear bear = new Bear();
            string growl = bear.Sound();
            Assert.Equal("Growl!", growl);
        }

        [Fact]
        public void OrangutanMakesSound()
        {
            Orangutan orangutan = new Orangutan();
            string ohah = orangutan.Sound();
            Assert.Equal("Ooh Oh Ah Aah", ohah);
        }

        [Fact]
        public void OwlMakesSound()
        {
            Owl owl = new Owl();
            string hoot = owl.Sound();
            Assert.Equal("Twoo Twoo", hoot);
        }

        [Fact]
        public void GoldfishMakesSound()
        {
            GoldFish goldFish = new GoldFish();
            string bloop = goldFish.Sound();
            Assert.Equal("Bloop, bloop", bloop);
        }
    }
}
