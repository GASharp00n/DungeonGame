using System;

class Hero : Character
{
    private int m_iStrength;

    private List<HeroWeapons> m_Arsenal;

    public Hero(int LP, int STR) : base(LP)
    {
        m_iStrength = STR;
        m_Arsenal = new List<HeroWeapons>();
        m_Arsenal.Add(new Sword(10));
        m_Arsenal.Add(new Arrow(10));
        m_Arsenal.Add(new WaterFlask(10));
        m_Arsenal.Add(new Spear(10));
        m_Arsenal.Add(new FireArrow(10));
    }

    public override void attack(Character p_TargetCharacter)
    {

    }

    public void discoverEnemy(Monster p_Monster)
    {
        selectWeaponFromArsenal(p_Monster.getEffectiveWeaponType());
        Console.WriteLine(m_Weapon.GetType().Name);
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
        Item found = p_Searchable.search();
        if (found != null)
        {
            found.applyEffect(this);
        }
    }

    public Dungeon tryPower(Dungeon p_Dungeon)
    {
        throw new NotImplementedException();
    }
    private void selectWeaponFromArsenal(string p_sWeaponClassName)
    {
        foreach (HeroWeapons weapon in m_Arsenal)
        {
            if (weapon.GetType().Name == p_sWeaponClassName)
            {
                m_Weapon = weapon;
                return;
            }
        }
    }
}