using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class ColdBlooded: Animal
    {
        public override bool Isliving { get; set; } = true;
        public override bool IsBreathing { get; set; } = true;
        public virtual bool HasColdBlood { get; } = true;
        public abstract int Legs { get; }

        public virtual bool ChangesBodyTemp()
        {
            return true;
        }
    }
}
