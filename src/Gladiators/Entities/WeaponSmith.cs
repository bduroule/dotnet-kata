using System;
using System.Collections.Generic;
using Gladiator.External;

namespace Gladiators.Entities
{
    public interface IWeaponSmith
    {
        Weapon BuildWeapon(WeaponTypes type);
    }

    public class WeaponSmith : IWeaponSmith
    {
        private Dictionary<WeaponTypes, Weapon> weaponByType = new Dictionary<WeaponTypes, Weapon>();

        public WeaponSmith()
        {
            InitDictionary();
        }

        private void InitDictionary()
        {
            weaponByType.Add(WeaponTypes.Club, new Weapon("Club", (float)1.50));
            weaponByType.Add(WeaponTypes.Fork, new Weapon("Fork", (float)1.10));
            weaponByType.Add(WeaponTypes.Sword, new Weapon("Sword", (float)2.00));
            weaponByType.Add(WeaponTypes.None, new Weapon("None", (float)1d));
        }

        public Weapon BuildWeapon(WeaponTypes type)
        {
            if (weaponByType.TryGetValue(type, out var weapon))
            {
                return weapon;
            }

            throw new Exception($"Unknown weapon type {type}");;
        }
    }
}
