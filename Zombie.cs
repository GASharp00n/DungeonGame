using System;

class Zombie : Monster
{
    public Zombie() : base(100)
    {
        s_iNbZombieInstances++;
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}