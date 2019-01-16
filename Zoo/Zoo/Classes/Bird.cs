using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird: WarmBlooded
    {
        public abstract bool HasBeak { get; set; }
        public abstract bool HasWings { get; set; }

        public bool Fly()
        {
            return true;
        }
    }
}
