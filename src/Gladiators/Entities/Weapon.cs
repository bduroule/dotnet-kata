using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiators.Entities
{
    public class Weapon
    {
        public Weapon(string name, float attackModifier)
        {
            this.AttackModifier = attackModifier;
            this.Name = name;
        }
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

        private float _attackModifier;
        public float AttackModifier {
            get => _attackModifier;
            set {
                if (value >= 0d)
                    _attackModifier = value;
                else
                    throw new Exception("attack modifier must be have a stricly positive value");
            }
        }
    }
}
