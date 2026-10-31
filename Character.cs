using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Character
{
    protected int m_iLifePoints;

    protected Weapon m_Weapon;

    public Character(int LP)
    {
        m_iLifePoints = LP;
    }

    public virtual void attack(Character p_TargetCharacter)
    {

    }

    public int getNbLifePoints()
    {
        return m_iLifePoints;
    }

    public void receiveDamages(int p_iDamages)
    {
        m_iLifePoints -= p_iDamages;
        Console.WriteLine(GetType().Name + " has been hit and has now " + m_iLifePoints + " life points left ");
    }

    public bool isalive()
    {
        return true;
    }
}