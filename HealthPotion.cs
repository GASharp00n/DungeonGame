using System;

class HealthPotion : Item
{
    public HealthPotion()
    {
        m_iEffectValue = 10;
    }

    public override void applyEffect(Hero p_Hero)
    {
        p_Hero.improveHealth(m_iEffectValue);
    }
}