using System;

class Troll : Monster
{
    public Troll() : base(100)
    {
        s_iNbTrollInstances++;
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}