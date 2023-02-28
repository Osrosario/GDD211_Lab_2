using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAssigner : MonoBehaviour
{
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private Sprite weaponSpr;

    private Image image;

    public void AssignImage()
    {
        image = sceneMaster.GetComponent<ImageHolder>().GetImage();

        image.color = new Color(image.color.r, image.color.b, image.color.g, 1);
        image.sprite = weaponSpr;
    }
}
