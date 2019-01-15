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
            Console.WriteLine($"I say: '{tiger.Sound()}'");
            Console.WriteLine($"I have {tiger.Legs} legs.");

            Bear bear = new Bear();
            Console.WriteLine(">>>>BEAR<<<<<");
            Console.WriteLine(bear.Eat());
            Console.WriteLine($"I say: '{bear.Sound()}'");
            Console.WriteLine($"I have {bear.Legs} legs.");

            Orangutan orangutan = new Orangutan();
            Console.WriteLine(">>>>ORANGUTAN<<<<");
            Console.WriteLine(orangutan.Eat());
            Console.WriteLine($"I say: '{orangutan.Sound()}'");

            Owl owl = new Owl();
            Console.WriteLine(">>>>OWL<<<<");
            Console.WriteLine(owl.Eat());
            Console.WriteLine($"I say: '{owl.Sound()}'");
            Console.WriteLine($"I have {owl.Legs} legs.");


            GoldFish goldfish = new GoldFish();
            Console.WriteLine(">>>>GOLD FISH<<<<");
            Console.WriteLine(goldfish.Eat());
            Console.WriteLine($"I say: '{goldfish.Sound()}'");
        }
    }
}
