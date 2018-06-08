using System;
using System.Collections.Generic;
using System.Text;
using static CoreConsoleAppDesignPatterns.BattleEngine;

namespace CoreConsoleAppDesignPatterns
{
    static class CreatureFactory
    {
        public static ICreature CreateCreature()
        {
            int roll = Roll(100);
            if(roll < 25)
            {
                return new Troll();
            }
            else if(roll < 50)
            {
                return new Skeleton();
            }
            else if(roll < 75)
            {
                return new Ogre();
            }
            else
            {
                return new BananaGuard();
            }
        }
    }
}
