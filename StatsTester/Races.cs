using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StatsTester.Util;

namespace StatsTester
{
    class Human : Character
    {

        
        public Human(string name, Job job, bool isDead = false, Weapon weapon = null): base(name, job, Race.Human, isDead, weapon)
        {
            statsList = new List<int>{ 2, 2, 1, 3, 1, 2, 30, 15 };
            addStr();
            addDef();
            addInte(5);
            addLuck(3);
            addHP(5);
            
        }


    }

    class Dwarf : Character
    {
        
        public Dwarf(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Dwarf,  isDead, weapon)
        {
            statsList = new List<int> { 3, 1, 4, 0, 0, 3, 30, 15 };
            addStr(3);
            addDef(5);
            addLuck(2);
            addHP(5);
        }


    }

    class Elf : Character
    {
        
        public Elf(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Elf, isDead, weapon)
        {
            statsList = new List<int> { 1, 3, 1, 1, 4, 1, 15, 30 };
            addDex(3);
            addWis(5);
            addMP(7);
        }


    }

    class Orc : Character
    {
        public Orc(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Orc, isDead, weapon)
        {
            statsList = new List<int> { 4, 3, 3, 1, 1, 1, 40, 15 };
            addStr(4);
            addDex(2);
            addDef(2);
            addHP(7);
        }


    }

    class Gnome : Character
    {
        public Gnome(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Gnome, isDead, weapon)
        {
            statsList = new List<int> { 4, 3, 3, 1, 1, 1, 40, 15 };
            addStr(4);
            addDex(2);
            addDef(2);
            addHP(7);
        }
    }

    class Troll : Character
    {
        public Troll(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Orc, isDead, weapon)
        {
            statsList = new List<int> { 5, 1, 4, 1, 1, 1, 50, 15 };
            addStr(4);
            addDef(4);
            addHP(7);
        }


    }

    class Goblin : Character
    {
        public Goblin(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Orc, isDead, weapon)
        {
            statsList = new List<int> { 2, 5, 3, 1, 1, 1, 40, 15 };
            addStr(2);
            addDex(4);
            addDef(2);
            addHP(7);
        }


    }

    class Ogre : Character
    {
        public Ogre(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Orc, isDead, weapon)
        {
            statsList = new List<int> { 4, 3, 3, 1, 1, 1, 40, 15 };
            addStr(2);
            addDef(6);
            addHP(7);
        }


    }

    class Skeleton : Character
    {
        public Skeleton(string name, Job job, bool isDead = false, Weapon weapon = null) : base(name, job, Race.Orc, isDead, weapon)
        {
            statsList = new List<int> { 4, 3, 3, 1, 1, 1, 40, 15 };
            addHP(5);
            addWis(5);
            addMP(7);
        }


    }
}



