using System;

class Dungeon
{
    private Room[] m_RoomsArray;


    public Dungeon(int NbRooms, bool CreationInfo)
    {
        Monster.s_iNbZombieInstances = 0;
        Monster.s_iNbThiefInstances = 0;
        Monster.s_iNbSorcererInstances = 0;
        Monster.s_iNbBarbarianInstances = 0;
        Monster.s_iNbTrollInstances = 0;

        m_RoomsArray = new Room[NbRooms];
        for (int i = 0; i < NbRooms; i++)
        {
            Monster monster;
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
        if (CreationInfo)
        {
            Console.WriteLine("Zombie : " + Monster.s_iNbZombieInstances);
            Console.WriteLine("Barbarian : " + Monster.s_iNbBarbarianInstances);
            Console.WriteLine("Sorcerer : " + Monster.s_iNbSorcererInstances);
            Console.WriteLine("Thief : " + Monster.s_iNbThiefInstances);
            Console.WriteLine("Troll : " + Monster.s_iNbTrollInstances);
        }
    }

    public Room getRoom(int RoomIndex)
    {
        return m_RoomsArray[RoomIndex];
    }

    public void greetHeros(Hero Heros)
    {
        foreach (Room room in m_RoomsArray)
        {
            room.enterRoom(Heros);
            if (Heros.isalive() == false)
            {
                Console.WriteLine("Sorry, you have lost");
                return;
            }
            Heros.tryPower(this);
        }
        Console.WriteLine("Congratulation you have won");
    }

    public Monster[] getAllMonstersFromDungeon()
    {
        Monster[] monsters = new Monster[m_RoomsArray.Length];
        for (int i = 0; i < m_RoomsArray.Length; i++)
        {
            monsters[i] = m_RoomsArray[i].getMonster();
        }
        return monsters;
    }
}