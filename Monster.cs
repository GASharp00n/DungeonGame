using System;

class Monster : Character, Searchable
{
    public string m_sEffectiveWeaponType;

    public static int s_iNbZombieInstances;

    public static int s_iNbThiefInstances;

    public static int s_iNbSorcererInstances;

    public static int s_iNbBarbarianInstances;

    public static int s_iNbTrollInstances;

    private bool m_bSearchDone;

    protected Item m_Item;


    public Item search()
    {
        return null;
    }
    public Monster(int LP) : base(LP)
    {
    }

    public string getEffectiveWeaponType()
    {
        return m_sEffectiveWeaponType;
    }

    public override void attack(Character p_TargetCharacter)
    {

    }

    public virtual void hitByPower(ReduceLifePower p_Power)
    {

    }

    public bool isWeaponEfficient(Weapon p_Weapon)
    {
        return true;
    }


}