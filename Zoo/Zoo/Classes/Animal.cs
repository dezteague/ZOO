using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public abstract bool Isliving { get; set; }
        public abstract bool IsBreathing { get; set; }

        public abstract string Eat();
        public abstract void Sleep();
        public abstract void Reproduce();
        public abstract string Sound();
    }
}
