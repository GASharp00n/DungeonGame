using System;

class Barbarian : Monster
{
    public Barbarian() : base(100)
    {
        s_iNbBarbarianInstances++;
        if (s_iNbBarbarianInstances % 2 == 1)
        {
            m_Item = new StrengthPotion();
        }
        else
        {
            m_Item = new HealthPotion();
        }
        m_Weapon = new Axe(10);
        m_sEffectiveWeaponType = "Sword";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}