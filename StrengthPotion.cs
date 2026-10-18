using System;

class StrengthPotion : Item
{
    public StrengthPotion()
    {
        m_iEffectValue = 20;
    }

    public override void applyEffect(Hero p_Hero)
    {
        p_Hero.improveStrength(m_iEffectValue);
    }
}
