using Xunit;
using Gladiators.Entities;
using System;

namespace Gladiator
{
    public class FightShould
    {
        [Fact]
        public void TestFightGladiatorsIsDead()
        {
            GladiatorClass maximus = new GladiatorClass("Maximus", 60, 15);
            GladiatorClass brutus = new GladiatorClass("Brutus", 60, 15);
            bool IsNotDead = false;
            bool IsDead = true;


            Fight fight = new Fight(maximus, brutus);
            Assert.Equal(fight.GladiatorsIsDead(), IsNotDead);
            maximus.HealthPoints = 0;
            Assert.Equal(fight.GladiatorsIsDead(), IsDead);
        }

        /*[Fact]
        public void TestFightAreaFight()
        {
            GladiatorClass maximus = new GladiatorClass("Maximus", 60, 15);
            GladiatorClass brutus = new GladiatorClass("Brutus", 60, 15);
            bool IsNotDead = false;


            Fight fight = new Fight(maximus, brutus);
            Assert.Equal(fight.GladiatorsIsDead(), IsNotDead);
            maximus.HealthPoints = 0;
            Assert.Throws<Exception>(() => fight.GladiatorsIsDead());
        }*/
    }
}