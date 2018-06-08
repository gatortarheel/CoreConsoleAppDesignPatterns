using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppDesignPatterns
{
    public interface ICreature
    {
        void Attack(List<ICreature> creatures);
        int Initiative();
        int CalculateDamage();
        void DisplayStatus();

        int ArmorClass
        {
            get;
            set;
        }

        int ToHitModifier
        {
            get;
            set;
        }

        int BaseAttackBonus
        {
            get;
            set;
        }

        int BaseDamage
        {
            get;
            set;
        }

        int BaseHitPoints
        {
            get;
            set;
        }

        int CurrentHitPoints
        {
            get;
            set;
        }


        string Name
        {
            get;
            set;
        }

    }
}
