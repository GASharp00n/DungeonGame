using System;

class HeroWeapons : Weapon
{
    private int m_iAttackBonus;
    public HeroWeapons(int p_iDamages)
    {
        m_iAttackPoints = p_iDamages;
    }
    public override void inflictDamage(Character p_TargetCharacter)
    {
        Console.WriteLine("Heros responds to the attack with its " + GetType().Name);
        p_TargetCharacter.receiveDamages(m_iAttackPoints + m_iAttackBonus);
    }

    public void setAttackBonus(int p_iBonus)
    {
        m_iAttackBonus = p_iBonus;
    }
}