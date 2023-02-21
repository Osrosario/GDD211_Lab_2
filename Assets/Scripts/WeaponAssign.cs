using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponAssign : MonoBehaviour
{
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private Sprite weaponSpr;

    private Selection selectMaster;
    private GameObject image;

    private void Start()
    {
        selectMaster = sceneMaster.GetComponent<Selection>();        
    }

    public void AssignWeapon()
    {
        image = sceneMaster.GetComponent<Selection>().GetButton();

        image.GetComponent<Image>().color = new Color
            (
            image.GetComponent<Image>().color.r,
            image.GetComponent<Image>().color.b,
            image.GetComponent<Image>().color.g,
            1
            );

        image.GetComponent<Image>().sprite = weaponSpr;
    }

}
