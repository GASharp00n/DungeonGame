using System;

class MonsterWeapon : Weapon
{
    private int m_iCriticalCountDown;

    private static readonly int s_iMaxRoundBeforeCritical = 4;

    public MonsterWeapon(int p_iDamages)
    {
        m_iAttackPoints = p_iDamages;
    }
    public override void inflictDamage(Character p_TargetCharacter)
    {
        Console.WriteLine("The " + GetType().Name + " is inflicting " + m_iAttackPoints + " damages to the heros");
        p_TargetCharacter.receiveDamages(m_iAttackPoints);
    }
}