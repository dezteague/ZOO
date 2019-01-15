using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Bear : Mammal
    {
        public override int Legs => 2;
        public override string Eat()
        {
            return "Honey comb please!";
        }

        public override void Reproduce()
        {
            //bear cubs
        }

        public override void Sleep()
        {
            //bear cave
        }

        public override string Sound()
        {
            return "Growl!";
        }
    }
}
