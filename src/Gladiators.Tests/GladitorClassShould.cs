using Xunit;
using Gladiators.Entities;
using System;

namespace Gladiators.Tests
{
    public class GladiatorsClassShould
    {
        [Fact]
        public void testNamePropertie()
        {
            string name = "Maximus";
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", 10, 10);
            string lessThanTreeChar = "12";
            string moreThanFifteenChar = "1234567891234567";

            Assert.NotNull(gladiator1.Name);
            Assert.Equal(gladiator1.Name, name);
            Assert.Throws<Exception>(() => gladiator1.Name = lessThanTreeChar);
            Assert.Throws<Exception>(() => gladiator1.Name = moreThanFifteenChar);
        }

        [Fact]
        public void testHealthPointsPropertie()
        {
            int healthPoints = 10;
            int negativeHealthPoint = 0;
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", healthPoints, 15);

            Assert.Equal(gladiator1.HealthPoints, healthPoints);
            gladiator1.HealthPoints = -1;
            Assert.Equal(gladiator1.HealthPoints, negativeHealthPoint);
        }

        [Fact]
        public void testAttackPropertie()
        {
            int attack = 15;
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", 10, attack);

            Assert.Equal(gladiator1.Attack, attack);
            Assert.Throws<Exception>(() => gladiator1.Attack = -1);
        }

        [Fact]
        public void testDomagePropertie()
        {
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", 10, 15);

            Assert.NotNull(gladiator1.Damage);
            Assert.Throws<Exception>(() => gladiator1.Damage = -1);
            Assert.Throws<Exception>(() => gladiator1.Damage = 0.7);
        }

        [Fact]
        public void testIsDeadPropertie()
        {
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", 10, 15);
            bool IsDead = true;
            bool IsNotDead = false;

            Assert.Equal(gladiator1.IsDead, IsNotDead);
            gladiator1.HealthPoints = 0;
            Assert.Equal(gladiator1.IsDead, IsDead);
        }


        [Fact]
        public void testTakeDomagePropertie()
        {
            int healthPoints = 20;
            GladiatorClass gladiator1 = new GladiatorClass("Maximus", healthPoints, 15);
            int domage = 12;
            int valueAfterDomage = healthPoints - domage;

            gladiator1.TakeDomage(domage);
            Assert.Equal(gladiator1.HealthPoints, valueAfterDomage);
        }

    }
}
