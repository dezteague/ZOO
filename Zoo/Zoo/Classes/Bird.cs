using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Bird: WarmBlooded
    {
        public abstract bool HasBeak { get; set; }

        public bool Fly()
        {
            return true;
        }
    }
}
