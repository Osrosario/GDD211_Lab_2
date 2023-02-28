using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeapons : MonoBehaviour
{
    [Header("Reference(s)")]
    [SerializeField] private GameObject HB_Fill;
    [SerializeField] private Button chargeButton;
    [SerializeField] private Button attackPButton;
    [SerializeField] private Button confirmButton;

    [Header("Weapons")]
    [SerializeField] private List<string> weaponList = new List<string>();
    [SerializeField] private List<Sprite> weaponSprList = new List<Sprite>();

    private Slider healthbar;
    private bool isCharged = false;

    private void Start()
    {
        healthbar = HB_Fill.GetComponent<Slider>();
        weaponList.Add("None");
        weaponList.Add("None");
        weaponList.Add("None");
    }

    public void EmptyWeaponList()
    {
        weaponList[0] = "None";
        weaponList[1] = "None";
        weaponList[2] = "None";
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

    public void SetChargeState(bool value)
    {
        isCharged = value;
    }

    public bool GetChargeState()
    {
        return isCharged;
    }

    public void CheckWeapons()
    {
        if (!isCharged)
        {
            if (weaponList.Contains("charge"))
            {
                chargeButton.interactable = false;
            }
            else
            {
                chargeButton.interactable = true;
            }
        }
        else
        {
            if (weaponList.Contains("swordPowered"))
            {
                attackPButton.interactable = false;
            }
            else
            {
                attackPButton.interactable = true;
            }
        }
    }

    public void AssignSprite(Sprite weaponImg)
    {
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

    private void Update()
    {
        if (weaponList.Contains("None"))
        {
            confirmButton.interactable = false;
        }
        else
        {
            confirmButton.interactable = true;
        }
    }
}
