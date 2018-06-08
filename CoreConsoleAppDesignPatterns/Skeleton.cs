using System;
using System.Collections.Generic;
using System.Text;
using static CoreConsoleAppDesignPatterns.BattleEngine;
using static System.Console;

namespace CoreConsoleAppDesignPatterns
{
    public class Skeleton : ICreature
    {
        public Skeleton()
        {
            BaseHitPoints = 36 + 6 * Roll(6);
            ArmorClass = 10;
            BaseAttackBonus = Roll(10);
            CurrentHitPoints = BaseHitPoints;
            BaseDamage = 8;
            Name = String.Format("Skeleton {0}", this.BaseHitPoints);
            ToHitModifier = 0;
        }


        public void DisplayStatus()
        {
            WriteLine("{0} Stats - AC {1}   HP {2}  Current HP {3}", this.Name, this.ArmorClass, this.BaseHitPoints, this.CurrentHitPoints);
            if (CurrentHitPoints <= 0)
            {
                WriteLine("{0} is dead.", this.Name);
            }
        }

        public void Attack(List<ICreature> defenders)
        {
            foreach (ICreature t in defenders)
            {
                int rollRequired = 0;
                int roll = 0;
                rollRequired = CalculateRollNeededToHit(this, t);
                roll = Roll(20);
                if (roll >= rollRequired)
                {
                    int attackerDamage = CalculateDamage();
                    t.CurrentHitPoints = t.CurrentHitPoints - attackerDamage;
                    Console.WriteLine("{0} is attacking {1} - needed {2}, rolled a {3} [HIT] for {4} damage resulting in {5} HP.", this.Name, t.Name, rollRequired, roll, attackerDamage, t.CurrentHitPoints);
                }
                else
                {
                    Console.WriteLine("{0} is attacking {1} - needed {2}, rolled a {3} [MISS].", this.Name, t.Name, rollRequired, roll);
                }
            }
        }


        public int Initiative()
        {
            return Roll(6);
        }

        public int CalculateDamage()
        {
            //TODO: criticalhit?
            return Roll(this.BaseDamage);
        }
        public int ArmorClass
        {
            get;
            set;
        }

        public int BaseAttackBonus
        {
            get;
            set;
        }

        public int BaseDamage
        {
            get;
            set;
        }

        public int BaseHitPoints
        {
            get;
            set;
        }

        public int CurrentHitPoints
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public int ToHitModifier
        {
            get;
            set;
        }
    }
}
