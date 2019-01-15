using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Tiger: Mammal
    {

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
            Console.WriteLine("Hear me Roar!");
        }


    }
}
