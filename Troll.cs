using System;

class Troll : Monster
{
    public Troll() : base(100)
    {
        s_iNbTrollInstances++;
        if (s_iNbTrollInstances % 4 == 3)
        {
            m_Item = new StrengthPotion();
        }
        m_Weapon = new Club(10);
        m_sEffectiveWeaponType = "Spear";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}