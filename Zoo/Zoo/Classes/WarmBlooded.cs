using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class WarmBlooded: Animal
    {
        public override bool Isliving { get; set; } = true;
        public override bool IsBreathing { get; set; } = true;
        public virtual bool HasWarmBlood { get; } = true;
        public abstract int Legs { get; }

        public virtual bool DoesntChangeBodyTemp()
        {
            return true;
        }
    }
}
