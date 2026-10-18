using System;

class Barbarian : Monster
{
    public Barbarian() : base(100)
    {
        s_iNbBarbarianInstances++;
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}