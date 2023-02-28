using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CpuWeapons : MonoBehaviour
{
    [SerializeField] private GameObject HB_Fill;

    [SerializeField] private List<Sprite> spriteList = new List<Sprite>();
    [SerializeField] private List<string> weaponList = new List<string>();
    [SerializeField] private List<Sprite> weaponSprList = new List<Sprite>();

    private Slider healthbar;
    private bool isCharged = false;

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

    public void ChargeState(bool value)
    {
        isCharged = value;
    }

    public void AssignWeapons()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = Random.Range(0, spriteList.Count - 1);
            Sprite sprite = spriteList[index];
            
            if (sprite.name == "Sword_Unpowered")
            {
                weaponList.Add("sword");
                weaponSprList.Add(sprite);
            }
            else if (sprite.name == "Shield")
            {
                weaponList.Add("shield");
                weaponSprList.Add(sprite);
            }
            else if (sprite.name == "Charge_Up")
            {
                if (!isCharged)
                {
                    if (!weaponList.Contains("charge"))
                    {
                        weaponList.Add("charge");
                        weaponSprList.Add(sprite);
                    }
                    else
                    {
                        index = Random.Range(0, spriteList.Count - 3);
                        sprite = spriteList[index];

                        if (sprite.name == "Sword_Unpowered")
                        {
                            weaponList.Add("sword");
                            weaponSprList.Add(spriteList[index]);
                        }

                        if (sprite.name == "Shield")
                        {
                            weaponList.Add("shield");
                            weaponSprList.Add(spriteList[index]);
                        }
                    }
                }
                else
                {
                    if (!weaponList.Contains("swordPowered"))
                    {
                        weaponList.Add("swordPowered");
                        weaponSprList.Add(spriteList[3]);
                    }
                    else
                    {
                        index = Random.Range(0, spriteList.Count - 3);
                        sprite = spriteList[index];

                        if (sprite.name == "Sword_Unpowered")
                        {
                            weaponList.Add("sword");
                            weaponSprList.Add(spriteList[index]);
                        }
                        else if (sprite.name == "Shield")
                        {
                            weaponList.Add("shield");
                            weaponSprList.Add(spriteList[index]);
                        }
                    }
                }
            }
            else if (sprite.name == "Sword_Powered")
            {
                if (!isCharged)
                {
                    index = Random.Range(0, spriteList.Count - 2);
                    sprite = spriteList[index];

                    if (sprite.name == "Sword_Unpowered")
                    {
                        weaponList.Add("sword");
                        weaponSprList.Add(spriteList[index]);
                    }
                    else if (sprite.name == "Shield")
                    {
                        weaponList.Add("shield");
                        weaponSprList.Add(spriteList[index]);
                    }
                    else if (sprite.name == "Charge_Up")
                    {
                        if (!weaponList.Contains("charge"))
                        {
                            weaponList.Add("charge");
                            weaponSprList.Add(spriteList[index]);
                        }
                        else
                        {
                            index = Random.Range(0, spriteList.Count - 3);
                            sprite = spriteList[index];

                            if (sprite.name == "Sword_Unpowered")
                            {
                                weaponList.Add("sword");
                                weaponSprList.Add(spriteList[index]);
                            }
                            else if (sprite.name == "Shield")
                            {
                                weaponList.Add("shield");
                                weaponSprList.Add(spriteList[index]);
                            }
                        }
                    }
                }
                else
                {
                    if (!weaponList.Contains("swordPowered"))
                    {
                        weaponList.Add("swordPowered");
                        weaponSprList.Add(spriteList[3]);
                    }
                    else
                    {
                        index = Random.Range(0, spriteList.Count - 3);
                        sprite = spriteList[index];

                        if (sprite.name == "Sword_Unpowered")
                        {
                            weaponList.Add("sword");
                            weaponSprList.Add(spriteList[index]);
                        }
                        else if (sprite.name == "Shield")
                        {
                            weaponList.Add("shield");
                            weaponSprList.Add(spriteList[index]);
                        }
                    }
                }
            }
        }
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
