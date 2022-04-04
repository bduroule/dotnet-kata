using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiators.Entities
{
    public class Fight
    {
        private (GladiatorClass, GladiatorClass) gladiators;
        private static Random rand = new Random();

        public Fight(GladiatorClass gladiatorOne, GladiatorClass gladiatorTwo)
        {
            this.gladiators.Item1 = gladiatorOne;
            this.gladiators.Item2 = gladiatorTwo;

            if (GladiatorsIsDead()) 
                throw new Exception("at least one gladiator is dead");
        }

        public bool GladiatorsIsDead()
        {
            if (gladiators.Item1.IsDead)
                return true;
            if (gladiators.Item2.IsDead)
                return true;
            return false;
        }

        private void reverseGladiator()
        {
            GladiatorClass tmp = gladiators.Item1;
            gladiators.Item1 = gladiators.Item2;
            gladiators.Item2 = tmp;   
        }
        public GladiatorClass AreaFight()
        {
            if (GladiatorsIsDead()) 
                throw new Exception("at least one gladiator is dead");
            if (rand.Next(2) == 0)
                reverseGladiator();

            while (!GladiatorsIsDead()) {
                if (!gladiators.Item1.IsDead)
                    gladiators.Item2.TakeDomage(gladiators.Item1.Domage);
                else if (!gladiators.Item2.IsDead)
                    gladiators.Item1.TakeDomage(gladiators.Item2.Domage);
            }
            if (!gladiators.Item1.IsDead)
                return gladiators.Item1;
            else
                return gladiators.Item2;
        }
    }
}
