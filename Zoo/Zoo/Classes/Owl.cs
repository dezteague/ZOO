using Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Owl : Mammal, IFly, ISurvive, IProduceEggs
    {
        public string Fly()
        {
            return "I'm notcturnal, I fly through the night!";
        }

        public string Live()
        {
            return "I live in a nest";
        }

        public string Eggs()
        {
            return "My babies hatch from eggs";
        }

        public override int Legs => 2;
        public override string Eat()
        {
            return "Mice on the menu?";
        }

        public override void Reproduce()
        {
            //eggs in a nest
        }

        public override void Sleep()
        {
            //during the day
        }

        public override string Sound()
        {
            return "Twoo Twoo";
        }

    }
}
