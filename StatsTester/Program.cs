// See https://aka.ms/new-console-template for more information
using StatsTester;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;
using static Weapon;
using static StatsTester.Util;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System;

List<Weapon> weaponList = createWeapons();

Character paul = new Elf("Paul", Job.Bowman );
Character sexe = new Elf("Sexe",Job.Bowman);

attackTest(paul, sexe);
//onsole.WriteLine(getHotStuff());

sexe.equipWeapon(weaponList[2]);

attackTest(sexe, paul);

sexe.printStats();
Console.WriteLine("\n\n");
paul.printStats();

paul.performLevelUp(1,1,1,1,1,1,5,5);
sexe.performLevelUp(1, 1, 1, 1, 1, 1, 5, 5);

sexe.printStats();
Console.WriteLine("\n\n");
paul.printStats();

void printHP(Character character)
{
    Console.WriteLine("----------Character: " + character.getName() + "----------\nHP: " + character.getCurrentHP() + "\\" + character.getHP() + "\n");
}

void attackTest(Character attacker, Character defender)
{
    printHP(attacker);
    printHP(defender);
    Console.WriteLine(attacker.getName() + " attacks " + defender.getName() + "\n");
    Console.WriteLine(attacker.attack(defender));
    printHP(attacker);
    printHP(defender);
}
//Console.WriteLine(paul.getHotStuff());


string getHotStuff()
{
    //string[] list = { "name", "mt", "hit", "crit", "wt", "avo", "dodg", "range", "type", "grip"};
    string[] list = { "name", "level", "EXP", "str", "dex", "def", "inte", "wis", "luck", "currentHP", "HP", "currentMP", "MP" };

    //string name, int mt, int hit, int crit, int wt, int avo, int dodg, int range, WpnType type, WpnGrip grip
    string retour = "";

    for (int i = 0; i < list.Length; i++)
    {
        /*
        retour += "public void add";
        retour += char.ToUpper(list[i][0]);
        retour += list[i].Substring(1);
        retour += "(int num = 1)\n{\n this.";
        retour += list[i];
        retour += " = num; \n }\n";*/

        

        retour += "Console.WriteLine(\"";
        retour += list[i];
        retour += " :\" + get";
        retour += char.ToUpper(list[i][0]);
        retour += list[i].Substring(1);
        retour += "());\n";

        /*
        retour += "public void set";
        retour += char.ToUpper(list[i][0]);
        retour += list[i].Substring(1);
        retour += "(int ";
        retour += list[i];
        retour += ")\n{\n  this.";
        retour += list[i];
        retour += " = ";
        retour += list[i];
        retour += "; \n }\n";*/
    }

    return retour;
}


List<Weapon> createWeapons()
{
    List<Weapon> weaponList = new List<Weapon>();
    // Specify the path to your text file
   
    string projectPath = AppDomain.CurrentDomain.BaseDirectory;
    string filePath = projectPath + "Weapon.dat";
    // Create a list to store the elements


    // Read the content of the file
    string[] lines = File.ReadAllLines(filePath);

    // Process each line
    foreach (string line in lines)
    {
        // Split the line based on tabs
        string[] l = line.Split('\t');
        int[] n = new int[l.Length];
        for (int i = 2; i < n.Length; i++)
        {
            n[i] = int.Parse(l[i]);
        }
        WpnGrip grip;
        if (n[2] == 1) grip = WpnGrip.oneHand;
        else grip = WpnGrip.twoHands;

        // Add the elements to the list

        weaponList.Add(new Weapon(l[0], n[3], n[4], n[5], n[6], n[7], n[8], n[9], getWeaponType(l[1]), grip));
    }

    return weaponList;
}


WpnType getWeaponType(string inputString)
{
    WpnType o;
    switch (inputString)
    {
        case "sword":
            o = WpnType.sword;
            break;
        case "dagger":
            o = WpnType.dagger;
            break;
        case "axe":
            o = WpnType.axe;
            break;
        case "lance":
            o = WpnType.lance;
            break;
        case "bow":
            o = WpnType.bow;
            break;
        case "staff":
            o = WpnType.staff;
            break;
        case "wand":
            o = WpnType.wand;
            break;
        case "shield":
            o = WpnType.shield;
            break;
        default:
            o = WpnType.fist;
            break;
    }

    return o;
}