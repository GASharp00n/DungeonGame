using System;

class ReduceLifePower
{
    public void dischargeOnTarget(Barbarian p_Barbarian)
    {
        p_Barbarian.receiveDamages(10);
    }
    public void dischargeOnTarget(Sorcerer p_Sorcerer)
    {
        p_Sorcerer.receiveDamages(10);
    }

    public void dischargeOnTarget(Thief p_Thief)
    {
        p_Thief.receiveDamages(10);
    }

    public void dischargeOnTarget(Troll p_Troll)
    {
        p_Troll.receiveDamages(10);
    }

    public void dischargeOnTarget(Zombie p_Zombie)
    {
        p_Zombie.receiveDamages(10);
    }

}