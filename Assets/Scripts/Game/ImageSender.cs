using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ImageSender : MonoBehaviour
{
    public UnityEvent ImageSend;

    public void SendImage()
    {
        ImageSend.Invoke();
    }
}
