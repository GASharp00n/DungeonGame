using System;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero(500, 25);
        Dungeon D = new Dungeon(25, true);
        D.greetHeros(hero);
        Monster[] monsters = D.getAllMonstersFromDungeon();
        monsters[0].attack(hero);

    }
}