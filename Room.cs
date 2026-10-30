using System;

class Room : Searchable
{
    private Monster m_RoomMonster;

    private List<Item> m_Items;

    public Room(Monster p_Monster, int roomIndex)
    {
        m_RoomMonster = p_Monster;
        m_Items = new List<Item>();
        if (roomIndex % 7 == 0)
        {
            m_Items.Add(new HealthPotion());
        }
        if (roomIndex % 4 == 0)
        {
            m_Items.Add(new StrengthPotion());
        }
    }
    public Monster getMonster()
    {
        return m_RoomMonster;
    }

    public Item search()
    {
        if (m_Items.Count == 0)
        {
            return null;
        }
        Item found = m_Items[0];
        m_Items.RemoveAt(0);
        Console.WriteLine("Congrats you found a " + found.GetType().Name);
        return found;
    }
    public void enterRoom(Hero p_Hero)
    {

    }
}