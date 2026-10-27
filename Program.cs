using System;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero(200, 25);
        Dungeon D = new Dungeon(25, true);
        D.greetHeros(hero);
        HealthPotion healthpotion = new HealthPotion();
        healthpotion.applyEffect(hero);
        StrengthPotion strengthpotion = new StrengthPotion();
        strengthpotion.applyEffect(hero);
        Monster[] monsters = D.getAllMonstersFromDungeon();
        Console.WriteLine(monsters.Length);
        Console.WriteLine(monsters[0].GetType().Name);
        Console.WriteLine(monsters[24].GetType().Name);
    }
}