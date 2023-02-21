using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{
    [SerializeField] private Image choice1Spr;
    [SerializeField] private Image choice2Spr;
    [SerializeField] private Image choice3Spr;

    private List<string> weapons;

    private void Update()
    {
        weapons[0] = getChoice1();
        weapons[1] = getChoice2();
        weapons[2] = getChoice3();
    }

    private string getChoice1()
    {
        if (choice1Spr.sprite.name == "Sword_Unpowered")      { return "sword"; }
        else if (choice1Spr.sprite.name == "Shield")          { return "shield"; }
        else if (choice1Spr.sprite.name == "Charge_Up")       { return "charge"; }
        else if (choice1Spr.sprite.name == "Sword_Powered")   { return "swordPowered"; }
        else                                                  { return ""; }
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
