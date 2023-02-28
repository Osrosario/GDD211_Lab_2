using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHolder : MonoBehaviour
{
    private Image imageHeld;

    public void HoldImage(Image button)
    {
        imageHeld = button;
    }

    public Image GetImage()
    {
        return imageHeld;
    }
}
