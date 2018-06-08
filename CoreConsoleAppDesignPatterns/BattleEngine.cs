using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppDesignPatterns
{
    static class BattleEngine
    {
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public static int Roll(int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(1, max);
            }
        }

        public static int Roll(int dice, int max)
        {
            int result = 0;
            int i = 0;
            while (i < dice)
            {
                lock (getrandom) // synchronize
                {
                    result += getrandom.Next(1, max);
                }
                i++;
            }
            return result;
        }

        public static int CalculateRollNeededToHit(ICreature attacker, ICreature defender)
        {
            int percentModifier = 21 - (defender.ArmorClass - attacker.ToHitModifier);
            decimal sidesOnDie = 20;
            decimal percentChange = percentModifier/ sidesOnDie;
            int neededToHit = Convert.ToInt16(sidesOnDie * percentChange);

            if (neededToHit <= 0)
            {
                neededToHit = 1;
            }

            if (neededToHit > 20)
            {
                neededToHit = 20;
            }
            return neededToHit;
        }
    }
}
