using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    [SerializeField] public List<GameObject> choice1List;
    [SerializeField] public List<GameObject> choice2List;
    [SerializeField] public List<GameObject> choice3List;

    private GameObject imageHeld;

    public void HoldImage(GameObject button)
    {
        imageHeld = button;
        Debug.Log(imageHeld.name);
    }

    public GameObject GetButton()
    {
        return imageHeld;
    }
}
