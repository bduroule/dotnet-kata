using System;
using Gladiators.Entities;
using Gladiator.External;
using System.Collections.Generic;

namespace Gladiators.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GladiatorClass maximus = new GladiatorClass("Maximus", 60, 15);
            GladiatorClass brutus = new GladiatorClass("Brutus", 60, 15);
            Fight area = new Fight(maximus, brutus);

            Console.WriteLine($"max heal: {maximus.HealthPoints}, brut heal {brutus.HealthPoints}");

            Console.WriteLine($"max heal: {area.AreaFight().Name}");
            Dictionary<WeaponTypes, int> dic  = new Dictionary<WeaponTypes, int>();
            dic[WeaponTypes.Club] = 1;
            Console.WriteLine($"test enum {dic[WeaponTypes.Club]}");
        }
    }
}
