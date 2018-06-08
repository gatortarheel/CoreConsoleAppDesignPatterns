# CoreConsoleAppDesignPatterns
AbstractFactoryAttempt
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
