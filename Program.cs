using System;
using Prova2.src.Entities;

namespace Prova2
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight arus = new Knight("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
           Ninja ninja = new Ninja ("Wedge", 42, "Ninja");
           BlackWizard blackWizard = new BlackWizard ("Topapa", 32, "Black Wizard");

            Console.WriteLine(wizard.Attack(1)); 
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(blackWizard.Attack(7));
            Console.WriteLine(ninja.Attack(1));
            Console.WriteLine(ninja.Attack(5));

        }
    }
}
