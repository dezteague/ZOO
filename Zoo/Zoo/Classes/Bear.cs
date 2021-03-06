﻿using Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Bear : Mammal, ISurvive, IProduceCubs
    {
        public string Live()
        {
            return "I live in dense forest";
        }

        public string Cubs()
        {
            return "My babies are called cubs!";
        }

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
