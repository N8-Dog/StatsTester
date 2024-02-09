using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StatsTester
{
    public class Util
    {
        

        public enum WpnType
        {
            sword,
            dagger,
            axe,
            lance,
            bow,
            staff,
            wand,
            shield,
            fist
        }

        public enum WpnGrip
        {
            oneHand,
            twoHands,
            both
        }

        public enum Race
        {
            Human,
            Elf,
            Dwarf,
            Orc,
            Gnome
        }

        public enum Job
        {
            Warrior,
            Paladin,
            Barbarian,
            Bowman,
            Thief,
            Wizard,
            Necromancer,
            Cleric
        }
    }
}
