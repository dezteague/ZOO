using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal: WarmBlooded
    {
        public override bool HasWarmBlood { get; }
        public override int Legs { get; }

        public bool Walk()
        {
        return true;
        }

        public override bool DoesntChangeBodyTemp()
        {
            return base.DoesntChangeBodyTemp();
        }
    }

    
}
