using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Character
{
    protected int m_iLifePoints;

    public Character(int LP)
    {
        m_LifePoints = LP;
    }

    public void attack(Character p_TargetCharacter)
    {

    }

    public int getNbLifePoints()
    {
        return m_iLifePoints;
    }

    public void receiveDamages(int p_iDamages)
    {
        m_iLifePoints -= p_iDamages;
    }

    public bool isalive()
    {
        return true;
    }
}