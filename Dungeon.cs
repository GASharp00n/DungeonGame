using System;
using System.Security.Cryptography.X509Certificates;

class Dungeon
{
    private Room[] m_RoomsArray;

    public Monster monster;
    public Dungeon(int NbRooms, bool CreationInfo)
    {

        m_RoomsArray = new Room[NbRooms];
        for (int i = 0; i < NbRooms; i++)
        {
            bool Prime = true;
            if (i <= 3)
            {
                Prime = false;
            }
            else
            {
                for (int d = 2; d * d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
            }
            if (i % 12 == 0)
            {
                monster = new Barbarian();
            }
            else if (i % 4 == 0)
            {
                monster = new Thief();
            }
            else if (i % 3 == 0)
            {
                monster = new Troll();
            }
            else if (Prime)
            {
                monster = new Sorcerer();
            }
            else
            {
                monster = new Zombie();
            }
            m_RoomsArray[i] = new Room(monster, i);
            if (CreationInfo)
            {
                Console.WriteLine(i + " : " + monster.GetType().Name);
            }
        }
    }

    public Room getRoom(int RoomIndex)
    {
        return m_RoomsArray[RoomIndex];
    }

    public void greetHeros(Hero Heros)
    {
        Console.WriteLine("Bienvenu kayou " + Heros.getNbLifePoints() + "LP");
    }

    public Monster[] getAllMonstersFromDungeon()
    {
        return null;
    }
}