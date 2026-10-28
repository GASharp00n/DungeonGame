using System;

class Zombie : Monster
{
    public Zombie() : base(100)
    {
        s_iNbZombieInstances++;
        m_Weapon = new Bite(10);
        m_sEffectiveWeaponType = "FireArrow";
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}