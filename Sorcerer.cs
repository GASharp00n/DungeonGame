using System;

class Sorcerer : Monster
{
    public Sorcerer() : base(100)
    {
        s_iNbSorcererInstances++;
        m_Weapon = new Lightning(10);
        m_sEffectiveWeaponType = "WaterFlask";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}