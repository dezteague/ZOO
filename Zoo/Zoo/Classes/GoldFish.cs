using Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class GoldFish : Fish, ILive, IHaveEggs
    {
        public string Live()
        {
            return "I live in my fish bowl :(";
        }

        public string Eggs()
        {
            return "I lay soft eggs";
        }

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
