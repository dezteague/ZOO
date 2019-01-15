﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class GoldFish : Fish
    {
        public override bool HasFins { get; set; }
        public override bool HasGills { get; set; }

        public override int Legs => throw new NotImplementedException();

        public override string Eat()
        {
            return "Feed me pellets!";
        }

        public override void Reproduce()
        {
            //soft eggs
        }

        public override void Sleep()
        {
            //in a fish bowl
        }

        public override string Sound()
        {
            return "Bloop, bloop";
        }
    }
}
