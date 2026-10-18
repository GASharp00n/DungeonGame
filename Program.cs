using System;

class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero(200, 25);
        Dungeon D = new Dungeon(25, true);
        D.greetHeros(hero);
    }
}