using System;

namespace Gladiator.External
{
    /// <summary>
    /// DO NOT MODIFY
    /// </summary>
    public sealed class WeaponLooter
    {
        private Random _random;

        public WeaponLooter()
        {
            _random = new Random();
        }

        public WeaponTypes TryLootSomething()
        {
            var roll = _random.Next(100);
            if (roll < 80)
                return WeaponTypes.None;
            if (roll < 90)
                return WeaponTypes.Fork;
            if (roll < 96)
                return WeaponTypes.Club;

            return WeaponTypes.Sword;
        }
    }
}
