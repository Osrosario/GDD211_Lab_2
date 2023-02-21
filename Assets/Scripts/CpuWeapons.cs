using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CpuWeapons : MonoBehaviour
{
    [SerializeField] private List<Image> weaponSprites;

    private Dictionary<string, Image> weapons;

    public Dictionary<string, Image> GetWeapons()
    {
        return weapons;
    }
    
    public void AssignWeapons()
    {
        for (int i = 0; i > weaponSprites.Count - 1; i++)
        {
            int index = Random.Range(0, weaponSprites.Count - 2);
            Image weaponSpr = weaponSprites[index];
            
            if (weaponSpr.name == "Sword_Unpowered")
            {
                weapons.Add("sword", weaponSpr);
            }
            else if (weaponSpr.name == "Shield")
            {
                weapons.Add("shield", weaponSpr);
            }
            else if (weaponSpr.name == "Charge_Up")
            {
                weapons.Add("charge", weaponSpr);
            }
            else if (weaponSpr.name == "Sword_Powered")
            {
                weapons.Add("swordPowered", weaponSpr);
            }
        }
    }
}
