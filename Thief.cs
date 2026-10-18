using System;

class Thief : Monster
{
    public Thief() : base(100)
    {
        s_iNbThiefInstances++;
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}