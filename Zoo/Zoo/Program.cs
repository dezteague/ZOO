using System;
using Zoo.Classes;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deziree's Animal Kingdom!");
            Tiger tiger = new Tiger();
            Console.WriteLine(">>>>TIGER<<<<");
            Console.WriteLine(tiger.Eat());
            Console.WriteLine(tiger.Sound());

            Bear bear = new Bear();
            Console.WriteLine(">>>>BEAR<<<<<");
            Console.WriteLine(bear.Eat());
            Console.WriteLine(bear.Sound());

            Orangutan orangutan = new Orangutan();
            Console.WriteLine(">>>>ORANGUTAN<<<<");
            Console.WriteLine(orangutan.Eat());
            Console.WriteLine(orangutan.Sound());

            Owl owl = new Owl();
            Console.WriteLine(">>>>OWL<<<<");
            Console.WriteLine(owl.Eat());
            Console.WriteLine(owl.Sound());

            GoldFish goldfish = new GoldFish();
            Console.WriteLine(">>>>GOLD FISH<<<<");
            Console.WriteLine(goldfish.Eat());
            Console.WriteLine(goldfish.Sound());
        }
    }
}
