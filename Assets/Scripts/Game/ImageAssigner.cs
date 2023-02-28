using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAssigner : MonoBehaviour
{
    [Header("Reference(s)")]
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private GameObject player;

    [Header("Weapon")]
    [SerializeField] private Sprite weaponSpr;
    [SerializeField] private string weaponToAssign;

    private ImageHolder imageHolder;
    private PlayerWeapons plyrWeapons;
    private Image image;
    private int imageIndex;

    private void Start()
    {
        imageHolder = sceneMaster.GetComponent<ImageHolder>();
        plyrWeapons = player.GetComponent<PlayerWeapons>();
    }

    public void AssignImage()
    {
        (image, imageIndex) = imageHolder.GetImage();

        image.color = new Color(image.color.r, image.color.b, image.color.g, 1);
        image.sprite = weaponSpr;
        plyrWeapons.GetWeapons()[imageIndex] = weaponToAssign;
        plyrWeapons.CheckWeapons();
    }
}
