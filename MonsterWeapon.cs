using System;
using System.Net.NetworkInformation;

class MonsterWeapon : Weapon
{
    private int m_iCriticalCountDown;

    private static readonly int s_iMaxRoundBeforeCritical = 4;

    public override void inflictDamage(Character p_TargetCharacter)
    {

    }
}