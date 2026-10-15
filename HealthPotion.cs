using System;

class HealthPotion : Item
{
    public HealthPotion()
    {
        restoreValue = 30;
    }

    public override void applyEffect(Hero p_Hero)
    {
        p_Hero.improveHealth(restoreValue);
    }
}