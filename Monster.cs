using System;

class Monster
{
    public string m_sEffectiveWeaponType;

    public static int s_iNbZombieInstances;

    public static int s_iNbThiefInstances;

    public static int s_iNbSorcererInstances;

    public static int s_iNbBarbarianInstances;

    public static int s_iNbTrollInstances;

    private bool m_bSearchDone;

    public string getEffectiveWeaponType()
    {
        throw new NotImplementedException();
    }

    public void attack(Character p_TargetCharacter)
    {

    }

    public bool isWeaponEfficient(Weapon p_Weapon)
    {
        return true;
    }

    public void hitByPower(ReduceLifePower p_Power)
    {

    }
}