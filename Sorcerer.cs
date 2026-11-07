using System;

class Sorcerer : Monster
{
    public Sorcerer() : base(120)
    {
        s_iNbSorcererInstances++;
        if (s_iNbSorcererInstances % 3 == 0)
        {
            m_Item = new HealthPotion();
        }
        m_Weapon = new Lightning(14);
        m_sEffectiveWeaponType = "WaterFlask";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}