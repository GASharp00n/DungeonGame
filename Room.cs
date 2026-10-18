using System;

class Room
{
    private Monster m_RoomMonster;

    public Room(Monster p_Monster, int indexRoom)
    {
        m_RoomMonster = p_Monster;
    }
    public Monster getMonster()
    {
        return m_RoomMonster;
    }

    public void enterRoom(Hero p_Hero)
    {

    }
}