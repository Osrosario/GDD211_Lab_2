using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CpuWeapons : MonoBehaviour
{
    [SerializeField] private Image cpuIcon;
    [SerializeField] private GameObject HB_Fill;

    [SerializeField] private List<Sprite> spriteList = new List<Sprite>();
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

    public List<Sprite> GetSprite()
    {
        return weaponSpr;
    }

    public void AssignWeapons()
    {
        for (int i = 0; i < spriteList.Count; i++)
        {
            int index = Random.Range(0, spriteList.Count - 1);
            Sprite sprite = spriteList[index];
            
            if (sprite.name == "Sword_Unpowered")
            {
                weapons.Add("sword");
                weaponSpr.Add(sprite);
            }
            else if (sprite.name == "Shield")
            {
                weapons.Add("shield");
                weaponSpr.Add(sprite);
            }
            else if (sprite.name == "Charge_Up")
            {
                weapons.Add("charge");
                weaponSpr.Add(sprite);
            }
            else if (sprite.name == "Sword_Powered")
            {
                weapons.Add("swordPowered");
                weaponSpr.Add(sprite);
            }
        }
    }

    public void AssignImage(int index)
    {
        cpuIcon.GetComponent<Image>().color = new Color
            (
            cpuIcon.GetComponent<Image>().color.r,
            cpuIcon.GetComponent<Image>().color.b,
            cpuIcon.GetComponent<Image>().color.g,
            1
            );

        cpuIcon.GetComponent<Image>().sprite = weaponSpr[index];
    }
}
