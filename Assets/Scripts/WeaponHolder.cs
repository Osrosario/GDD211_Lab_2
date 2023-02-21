using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    private Dictionary<string, Image> weapons;

    public Dictionary<string, Image> GetWeapons()
    {
        return weapons;
    }

    public void AssignWeapon1(string weapon, Image weaponImg)
    {
        weapons.Add(weapon, weaponImg);
    }

    public void AssignWeapon2(string weapon, Image weaponImg)
    {
        weapons.Add(weapon, weaponImg);
    }

    public void AssignWeapon3(string weapon, Image weaponImg)
    {
        weapons.Add(weapon, weaponImg);
    }
}
