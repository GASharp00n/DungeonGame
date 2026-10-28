using System;

class Thief : Monster
{
    public Thief() : base(100)
    {
        s_iNbThiefInstances++;
        m_Weapon = new Dagger(10);
        m_sEffectiveWeaponType = "Arrow";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}