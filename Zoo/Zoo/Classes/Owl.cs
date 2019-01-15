using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Owl : Mammal
    {
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
