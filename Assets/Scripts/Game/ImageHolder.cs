using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHolder : MonoBehaviour
{
    private Image imageHeld;
    private int indexHeld;

    public void HoldImage(Image button, int choiceIndex)
    {
        imageHeld = button;
        indexHeld = choiceIndex;
    }

    public (Image, int) GetImage()
    {
        return (imageHeld, indexHeld);
    }
}
