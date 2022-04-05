using System;
using System.Text;
using Gladiator.External;

namespace Gladiators.Entities
{
    public class GladiatorClass
    {
         public GladiatorClass(string name, int healthPoints, int attack)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.Attack = attack;
            _weaponSmith = new WeaponSmith();
        }
        WeaponLooter looter = new WeaponLooter();

        private static Random rand = new Random();
        private double attackModifier = rand.NextDouble() * (1.3 - 0.8) + 0.8;
        private string _name;
        public string Name { 
            get => _name;
            set {
                if (value.Length > 3 && value.Length < 15) 
                    _name = value;
                else
                    throw new Exception("Name value must be contains between 3 to 15 chars");
            }
        }
        private int _healthPoints;
        public int HealthPoints {
            get => _healthPoints;
            set {
                if (value >= 0)
                    _healthPoints = value;
                else
                    _healthPoints = 0;
            }
        }
        private int _attack;
        private readonly IWeaponSmith _weaponSmith;

        public int Attack {
            get => _attack;
            set {
                if (value >= 0)
                    _attack = value;
                else
                    throw new Exception("Attack value must be grater or equal to 0");
            }
        }
        // ? just geter
        public int Damage {
            get
            {
                if ((int)Math.Ceiling(Attack * attackModifier) >= 0)
                {
                    var weaponType = looter.TryLootSomething();
                    return (int)Math.Ceiling((Attack * attackModifier) * _weaponSmith.BuildWeapon(weaponType).AttackModifier);
                }

                throw new Exception("Damage value must be grater or equal to 0");
            }
        }
        public bool IsDead { get => HealthPoints == 0; }

        public void TakeDomage(int domage)
        {
            if (domage < 0)
                throw new Exception("Damage value must be grater or equal to 0");
            HealthPoints -= domage;
        }

    }
}
