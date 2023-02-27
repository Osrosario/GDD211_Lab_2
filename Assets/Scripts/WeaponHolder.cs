using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    [SerializeField] private Image plyrIcon;
    [SerializeField] private GameObject HB_Fill;

    [SerializeField] private List<string> weapons = new List<string>();
    [SerializeField] private List<Sprite> weaponSpr = new List<Sprite>();

    private Slider healthbar;

    private void Start()
    {
        healthbar = HB_Fill.GetComponent<Slider>();
    }

    public void takeDamage(float damage)
    {
        float amount = healthbar.value - damage;
        healthbar.value = amount;
    }

    public List<string> GetWeapons()
    {
        return weapons;
    }

    public List<Sprite> GetWeaponSpr()
    {
        return weaponSpr;
    }

    public void AssignWeapon(string weapon, Sprite weaponImg)
    {
        weapons.Add(weapon);
        weaponSpr.Add(weaponImg);
    }

    public void AssignImage(int index)
    {
        plyrIcon.GetComponent<Image>().color = new Color
            (
            plyrIcon.GetComponent<Image>().color.r,
            plyrIcon.GetComponent<Image>().color.b,
            plyrIcon.GetComponent<Image>().color.g,
            1
            );

        plyrIcon.GetComponent<Image>().sprite = weaponSpr[index];
    }
}
