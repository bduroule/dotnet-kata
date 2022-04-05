using System;

namespace Gladiator.External
{
    public interface IRoll
    {
        int Next(int max);

    }
    public class DiceRoll : IRoll
    {
        private static readonly Random _random = new Random();
        public int Next(int max)
        {
            return _random.Next(max);
        }
    }

}
