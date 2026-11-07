using System;

class ReduceLifePower


{
    private int strength;
    public void dischargeOnTarget(Barbarian p_Barbarian)
    {
        p_Barbarian.receiveDamages(3 + strength);
    }
    public void dischargeOnTarget(Sorcerer p_Sorcerer)
    {
        p_Sorcerer.receiveDamages(3 + strength);
    }

    public void dischargeOnTarget(Thief p_Thief)
    {
        p_Thief.receiveDamages(3 + strength);
    }

    public void dischargeOnTarget(Troll p_Troll)
    {
        p_Troll.receiveDamages(3 + strength);
    }

    public void dischargeOnTarget(Zombie p_Zombie)
    {
        p_Zombie.receiveDamages(3 + strength);
    }

}