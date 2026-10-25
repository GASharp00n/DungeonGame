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
        p_TargetCharacter.receiveDamages(m_iAttackPoints);
    }

    public void setAttackBonus(int p_iBonus)
    {
        m_iAttackBonus = p_iBonus;
    }
}