using System;

class StrengthPotion
{
    public StrengthPotion()
    {
        setPower = 30;
    }

    public override void applyEffect(Hero p_Hero)
    {
        p_Hero.setStrength(setPower);
    }
}