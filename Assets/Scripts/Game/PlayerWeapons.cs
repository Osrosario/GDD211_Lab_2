using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeapons : MonoBehaviour
{
    [SerializeField] private GameObject HB_Fill;

    [SerializeField] private List<string> weaponList = new List<string>();
    [SerializeField] private List<Sprite> weaponSprList = new List<Sprite>();

    private Slider healthbar;

    private void Start()
    {
        healthbar = HB_Fill.GetComponent<Slider>();
    }

    public void ClearWeaponList()
    {
        weaponList.Clear();
        weaponSprList.Clear();

        ClearImage();
    }

    public float GetHealth()
    {
        return healthbar.value;
    }

    public void takeDamage(float damage)
    {
        float amount = healthbar.value - damage;
        healthbar.value = amount;
    }

    public List<string> GetWeapons()
    {
        return weaponList;
    }

    public void AssignWeapon(string weapon, Sprite weaponImg)
    {
        weaponList.Add(weapon);
        weaponSprList.Add(weaponImg);
    }

    public void AssignImage(int index)
    {
        gameObject.GetComponent<Image>().color = new Color
            (
            gameObject.GetComponent<Image>().color.r,
            gameObject.GetComponent<Image>().color.b,
            gameObject.GetComponent<Image>().color.g,
            1
            );

        gameObject.GetComponent<Image>().sprite = weaponSprList[index];
    }

    private void ClearImage()
    {
        gameObject.GetComponent<Image>().color = new Color
            (
                gameObject.GetComponent<Image>().color.r,
                gameObject.GetComponent<Image>().color.b,
                gameObject.GetComponent<Image>().color.g,
                0
            );
    }
}
