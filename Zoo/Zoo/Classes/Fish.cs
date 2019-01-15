using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Fish: ColdBlooded
    {
        public abstract bool HasFins { get; set; }
        public abstract bool HasGills { get; set; }
        public override bool HasColdBlood { get; }

        public bool Swim()
        {
            return true;
        }

        public override bool ChangesBodyTemp()
        {
            return base.ChangesBodyTemp();
        }
    }
}
