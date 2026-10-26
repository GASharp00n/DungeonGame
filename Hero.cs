using System;

class Hero : Character
{
    private int m_iStrength;

    public Hero(int LP, int STR) : base(LP)
    {
        m_iStrength = STR;

    }

    public override void attack(Character p_TargetCharacter)
    {
    }

    public void discoverEnemy(Monster p_Monster)
    {

    }

    public void setStrength(int p_iStrength)
    {
        m_iStrength = p_iStrength;
    }

    public void improveHealth(int p_iValue)
    {
        m_iLifePoints += p_iValue;
        Console.WriteLine("Hero has been restored " + p_iValue + " life points, he has now " + m_iLifePoints + " total life points");
    }

    public void improveStrength(int p_iValue)
    {
        m_iStrength += p_iValue;
        Console.WriteLine("Hero has been restored " + p_iValue + " strength points, he has now " + m_iStrength + " total strength");
    }

    public void searchForPotions(Searchable p_Searchable)
    {

    }

    public Dungeon tryPower(Dungeon p_Dungeon)
    {
        throw new NotImplementedException();
    }
    private void selectWeaponFromArsenal(string p_sWeaponClassName)
    {

    }
}