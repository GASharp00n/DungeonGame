using System;
using System.Net.NetworkInformation;

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

    }
}