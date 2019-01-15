using Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tiger: Mammal, ILive
    {
        public string Live()
        {
            return "I live in warm climates";
        }

        public override int Legs => 4;
        public override string Eat()
        {
            return "I eat my meat rare";
        }

        public override void Reproduce()
        {
            //Have babies
        }

        public override void Sleep()
        {
            //sleep in the grass
        }

        public override string Sound()
        {
            return "Roarrr";
        }


    }
}
