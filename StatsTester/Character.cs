using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static StatsTester.Util;

namespace StatsTester
{

    abstract class Character
    {
        private string name;
        private Job job;
        private Race race;
        private bool isDead;
        private Weapon weapon;
        private int nextLevel;
        public List<int> statsList;

        private int str, dex, def, inte, wis, luck, currentHP,HP, currentMP, MP, EXP, level ;

        public Character(string name, Job job, Race race, bool isDead, Weapon weapon)
        {
            this.name = name;
            this.job = job;
            this.EXP = 0;
            rollStats();
            this.isDead = isDead;
            this.weapon = weapon;
            this.nextLevel = 1000;
            this.level = 1;
            
            //statsList = { 1, 1, 1, 1, 1, 1, 10, 10 };
        }
        /*
        public Character(string name, Job job, int str, int dex, int def, int inte, int wis, int luck, int HP, int MP, bool isDead, Weapon weapon)
        {
            this.name=name;
            this.job=job;
            this.str = str;
            this.dex = dex;
            this.def   = def;
            this.inte = inte;  
            this.wis = wis;
            this.luck = luck;
            this.HP = HP;
            this.currentHP = HP;
            this.MP = MP;
            this.currentMP = MP;
            this.EXP = 0;
        }*/

        //TODO: systeme de stats
        private void rollStats()
        {
            this.str = 5;
            this.dex = 5;
            this.def = 5;
            this.inte = 5;
            this.wis = 5;
            this.luck = 5;
            this.HP = 25;
            this.currentHP = HP;
            this.MP = 15;
            this.currentMP = MP;
        }

        public void equipWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public string attack(Character target)
        {
            Random random = new Random();
            int damage = 0;
            int seed = random.Next(1, 100);
            int hit = 0;
            string outcome;

            if (this.weapon == null)
            {
                hit = dex + (100 - target.getDex());
                damage = str;
            }
            else
            {
                hit = this.weapon.getHit() + dex + (100 - target.getDex());
                damage = str + this.weapon.getWt() - target.getDef();
            }

            Console.WriteLine("seed :" + seed + "\n");
            Console.WriteLine("hit :" + hit + "\n");
            Console.WriteLine("damage :" + damage + "\n");


            if (hit >= seed)
            {
                if(damage <= 0)
                {
                    outcome = "no damage";
                }

                else
                {
                    target.receiveDamage(damage);
                    outcome = damage.ToString();
                }
                
            }

            else
            {
                outcome = "miss";
            }

            return outcome;
        }

        private void receiveDamage(int damage)
        {
            HP -= damage;
            if(HP <= 0)
            {
                isDead = true;
                currentHP = 0;
                currentMP = 0;
            }
        }

        //check if character should level up
        public bool isNextLevel()
        {
            return EXP >= nextLevel;
        }
        /*
        //makes character level up one level (random)
        public void performLevelUp()
        {
            Random random = new Random();
            level++;
            EXP -= nextLevel;
            nextLevel = (int)Math.Floor(nextLevel * 1.15f);
            addStr(random.Next(0, statsList[0]));
            addDex(random.Next(0, statsList[1]));
            addDef(random.Next(0, statsList[2]));
            addInte(random.Next(0, statsList[3]));
            addWis(random.Next(0, statsList[4]));
            addLuck(random.Next(0, statsList[5]));
            addHP(random.Next(10, statsList[6]));
            addMP(random.Next(10, statsList[7]));
        }
        */
        public void performLevelUp(int str, int dex, int def, int inte, int wis, int luck, int HP, int MP)
        {
            
            level++;
            EXP -= nextLevel;
            nextLevel = (int)Math.Floor(nextLevel * 1.15f);
            addStr(str);
            addDex(dex);
            addDef(def);
            addInte(inte);
            addWis(wis);
            addLuck(luck);
            addHP(HP);
            addMP(MP);
        }

        public void printStats()
        {
            Console.WriteLine("----------");
            Console.WriteLine("name :" + getName());
            Console.WriteLine("level :" + getLevel());
            Console.WriteLine("EXP :" + getEXP());
            Console.WriteLine("str :" + getStr());
            Console.WriteLine("dex :" + getDex());
            Console.WriteLine("def :" + getDef());
            Console.WriteLine("inte :" + getInte());
            Console.WriteLine("wis :" + getWis());
            Console.WriteLine("luck :" + getLuck());
            Console.WriteLine("currentHP :" + getCurrentHP());
            Console.WriteLine("HP :" + getHP());
            Console.WriteLine("currentMP :" + getCurrentMP());
            Console.WriteLine("MP :" + getMP());
        }



        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public Job getJob()
        {
            return this.job;
        }
        public void setJob(Job job)
        {
            this.job = job;
        }
        public Race getRace()
        {
            return this.race;
        }
        public void setRace(Race race)
        {
            this.race = race;
        }
        public int getStr()
        {
            return this.str;
        }
        public void setStr(int str)
        {
            this.str = str;
        }
        public int getDex()
        {
            return this.dex;
        }
        public void setDex(int dex)
        {
            this.dex = dex;
        }
        public int getDef()
        {
            return this.def;
        }
        public void setDef(int def)
        {
            this.def = def;
        }
        public int getInte()
        {
            return this.inte;
        }
        public void setInte(int inte)
        {
            this.inte = inte;
        }
        public int getWis()
        {
            return this.wis;
        }
        public void setWis(int wis)
        {
            this.wis = wis;
        }
        public int getLuck()
        {
            return this.luck;
        }
        public void setLuck(int luck)
        {
            this.luck = luck;
        }
        public int getCurrentHP()
        {
            return this.currentHP;
        }
        public void setCurrentHP(int currentHP)
        {
            this.currentHP = currentHP;
        }
        public int getHP()
        {
            return this.HP;
        }
        public void setHP(int HP)
        {
            this.HP = HP;
        }
        public int getCurrentMP()
        {
            return this.currentMP;
        }
        public void setCurrentMP(int currentMP)
        {
            this.currentMP = currentMP;
        }
        public int getMP()
        {
            return this.MP;
        }
        public void setMP(int MP)
        {
            this.MP = MP;
        }
        public int getEXP()
        {
            return this.EXP;
        }
        public void setEXP(int EXP)
        {
            this.EXP = EXP;
        }

        public void addStr(int num = 1)
        {
            this.str += num;
        }
        public void addDex(int num = 1)
        {
            this.dex += num;
        }
        public void addDef(int num = 1)
        {
            this.def += num;
        }
        public void addInte(int num = 1)
        {
            this.inte += num;
        }
        public void addWis(int num = 1)
        {
            this.wis += num;
        }
        public void addLuck(int num = 1)
        {
            this.luck += num;
        }
        public void addCurrentHP(int num = 1)
        {
            this.currentHP += num;
        }
        public void addHP(int num = 1)
        {
            this.HP += num;
        }
        public void addCurrentMP(int num = 1)
        {
            this.currentMP += num;
        }
        public void addMP(int num = 1)
        {
            this.MP += num;
            
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public int getLevel()
        {
            return this.level;
        }
    }


}
