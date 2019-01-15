using Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Orangutan : Mammal, ILive
    {
        public string Live()
        {
            return "I live in Borneo and Sumatra";
        }

        public override string Eat()
        {
            return "Bananas please!";
        }

        public override void Reproduce()
        {
            //Baby orangutans
        }

        public override void Sleep()
        {
            //sleeps in trees
        }

        public override string Sound()
        {
            return "Ooh Oh Ah Aah";
        }
    }
}
