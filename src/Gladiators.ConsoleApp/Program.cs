using System;
using Gladiator.External;

namespace Gladiators.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GladiatorClass maximus = new GladiatorClass("Maximus", 20, 15);

            maximus.TakeDomage(9);
            Console.WriteLine($"max heal: {maximus.HealthPoints}, max dead ? {maximus.IsDead}");
            maximus.TakeDomage(11);
            Console.WriteLine($"max heal: {maximus.HealthPoints}, max dead ? {maximus.IsDead}");
        }
    }
}
