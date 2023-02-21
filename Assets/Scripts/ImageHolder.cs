using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHolder : MonoBehaviour
{
    private GameObject imageHeld;

    public void HoldImage(GameObject button)
    {
        imageHeld = button;
        Debug.Log(imageHeld.name);
    }

    public GameObject GetImage()
    {
        return imageHeld;
    }
}
