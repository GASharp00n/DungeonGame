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

    }

    public void improveStrength(int p_iValue)
    {

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