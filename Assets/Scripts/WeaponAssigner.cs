using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponAssigner : MonoBehaviour
{
    [SerializeField] private GameObject playerSpr;
    [SerializeField] private Image choice1Spr;
    [SerializeField] private Image choice2Spr;
    [SerializeField] private Image choice3Spr;

    private WeaponHolder weaponHldr;

    private void Start()
    {
        weaponHldr = playerSpr.GetComponent<WeaponHolder>();
    }

    public void SendWeapons()
    {
        weaponHldr.AssignWeapon(getChoice1(), choice1Spr.sprite);
        weaponHldr.AssignWeapon(getChoice2(), choice2Spr.sprite);
        weaponHldr.AssignWeapon(getChoice3(), choice3Spr.sprite);
    }
    
    private string getChoice1()
    {
        if (choice1Spr.sprite.name == "Sword_Unpowered")    { return "sword"; }
        else if (choice1Spr.sprite.name == "Shield")        { return "shield"; }
        else if (choice1Spr.sprite.name == "Charge_Up")     { return "charge"; }
        else if (choice1Spr.sprite.name == "Sword_Powered") { return "swordPowered"; }
        else                                                { return ""; }
    }

    private string getChoice2()
    {
        if (choice2Spr.sprite.name == "Sword_Unpowered")    { return "sword"; }
        else if (choice2Spr.sprite.name == "Shield")        { return "shield"; }
        else if (choice2Spr.sprite.name == "Charge_Up")     { return "charge"; }
        else if (choice2Spr.sprite.name == "Sword_Powered") { return "swordPowered"; }
        else                                                { return ""; }
    }

    private string getChoice3()
    {
        if (choice3Spr.sprite.name == "Sword_Unpowered")    { return "sword"; }
        else if (choice3Spr.sprite.name == "Shield")        { return "shield"; }
        else if (choice3Spr.sprite.name == "Charge_Up")     { return "charge"; }
        else if (choice3Spr.sprite.name == "Sword_Powered") { return "swordPowered"; }
        else                                                { return ""; }
    }
}
