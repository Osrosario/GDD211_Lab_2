using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSender : MonoBehaviour
{
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private Image choiceImage;
    [SerializeField] private int choiceIndex;

    private ImageHolder imageHolder;

    public void Start()
    {
        imageHolder = sceneMaster.GetComponent<ImageHolder>();
    }

    public void SendImage()
    {
        imageHolder.HoldImage(choiceImage, choiceIndex);
    }
}
