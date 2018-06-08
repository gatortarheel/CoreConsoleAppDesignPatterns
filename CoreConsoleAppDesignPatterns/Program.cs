using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CoreConsoleAppDesignPatterns
{
    public class Program
    {
        //Creational
        //-Creational design patterns abstract the instantiation process.
        //-Make a system independent of how its objects are created, composed, and represented.
        //-Become important as systems evolve to depnd more on object composition that class inheritance.
        //-Emphasis shifts from hard coding a fixed set of behaviors toward defining a smaller
        //      set of fundamental behaviors that can be composed into any number of more complex ones.
        //
        //--Themes
        //  Encapsulate knowledge about which concrete classes the system uses.
        //  Hide how instances of these classes are put together.
        //  Provide a lot of flexibility in what gets created
        //                                  how it gets created
        //                                  when it gets created
        //Abstract Factory
        //  Provide an interface for creating families of related or dependent objects 
        //  without specifying their underlying classes
        //
        // Dungeon Duel - 
        // 1. Create a factory that creates a random ICreature
        // 2. Create two random ICreatures - 
        // 3. Have the two ICreatures fight using 
        //      Basic D&D battle sequences
        //      Initiative - 1-6 who goes first
        //      Hit Points - death at 0 hit points, no final attack
        //      Attack Success based on Armor Class / Attack Bonus calculation
        //      Damage Done is calculated based on Armor Class/ Attack Bonus calculation
        //      Battle Engine uses ICreature instances for battle

        

        public static void Main()
        {
            Console.WriteLine("Dungeon Duel - abstraction");
            List<ICreature> creatures = new List<ICreature>();
            int i = 0;
            //randomly pick two things to battle
            while(i < 2)
            {
                var monster = CreatureFactory.CreateCreature();
                creatures.Add(monster);
                i++;
            }
           

            //Order by Initiative Roll Desc
            var query = creatures.OrderByDescending(troll => troll.Initiative());
            var alive = creatures.Where(xx => xx.CurrentHitPoints > 0);
            while (alive.Count() == query.Count())
            {
                foreach (ICreature t in query)
                {
                    t.DisplayStatus();
                    var defenders = creatures.Where(xx => xx.Name != t.Name);
                    t.Attack(defenders.ToList());
                    if (t.CurrentHitPoints < 0)
                    {
                        break;
                    }

                    //query for creatures with hp > 0

                }
                alive = creatures.Where(xx => xx.CurrentHitPoints > 0);
                var dead = creatures.Where(xx => xx.CurrentHitPoints <= 0);
               
                if(dead.Count() > 0)
                {
                    foreach (ICreature t in dead)
                    {
                        WriteLine(t.Name + " is dead");
                    }
                    break;
                }

            }

           

            





            Console.ReadLine();
        }



    }
}