using System;
using System.Net.Mail;

class HeroWeapons : Weapon
{
    private int m_iAttackBonus;

    public int attackValue;

    public int p_iDamages;

    public string weaponName;

    public HeroWeapons(int p_iDamages, string p_weaponName)
    {
        m_iAttackPoints = p_iDamages;
        weaponName = p_weaponName;
    }
    public override void inflictDamage(Character p_TargetCharacter)
    {
        p_TargetCharacter.receiveDamages(p_iDamages);
    }

    public void setAttackBonus(int p_iBonus)
    {

    }
}