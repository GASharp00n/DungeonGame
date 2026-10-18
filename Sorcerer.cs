using System;

class Sorcerer : Monster
{
    public Sorcerer() : base(100)
    {
        s_iNbSorcererInstances++;
    }
    public override void hitByPower(ReduceLifePower p_Power)
    {
        p_Power.dischargeOnTarget(this);
    }
}