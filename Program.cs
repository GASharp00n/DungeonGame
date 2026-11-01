using System;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero(500, 25);
        Dungeon D = new Dungeon(25, true);
        Monster[] monsters = D.getAllMonstersFromDungeon();
        D.getRoom(0).enterRoom(hero);

    }
}