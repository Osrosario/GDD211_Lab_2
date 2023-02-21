using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SendImage : MonoBehaviour
{
    public UnityEvent ImagePass;

    public void PassImage()
    {
        ImagePass.Invoke();
    }
}
