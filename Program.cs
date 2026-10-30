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
        hero.searchForPotions(monsters[0]);
        hero.searchForPotions(monsters[0]);
        hero.searchForPotions(monsters[2]);
        hero.searchForPotions(monsters[12]);
        Console.WriteLine(monsters.Length);
        Console.WriteLine(monsters[0].GetType().Name);
        Console.WriteLine(monsters[24].GetType().Name);
        hero.searchForPotions(D.getRoom(7));
        hero.searchForPotions(D.getRoom(4));
        hero.searchForPotions(D.getRoom(0));
        hero.searchForPotions(D.getRoom(0));
        hero.searchForPotions(D.getRoom(0));
        hero.searchForPotions(D.getRoom(1));

    }
}