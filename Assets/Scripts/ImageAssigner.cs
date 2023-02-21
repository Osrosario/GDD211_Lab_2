using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAssigner : MonoBehaviour
{
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private Sprite weaponSpr;

    private GameObject image;

    public void AssignImage()
    {
        image = sceneMaster.GetComponent<ImageHolder>().GetImage();

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
