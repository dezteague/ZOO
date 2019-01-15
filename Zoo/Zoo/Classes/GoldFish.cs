using System;
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
            throw new NotImplementedException();
        }

        public override void Reproduce()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            throw new NotImplementedException();
        }
    }
}
