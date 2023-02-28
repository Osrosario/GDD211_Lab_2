using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChanger : MonoBehaviour
{
    [SerializeField] private List<GameObject> screenList = new List<GameObject>();
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;

    [SerializeField] private int screenIndex;

    public void changeScreen(int value)
    {
        screenIndex = screenIndex + value;

        for (int i = 0; i < screenList.Count; i++)
        {
            if (i == screenIndex)
            {
                screenList[i].SetActive(true);
            }
            else
            {
                screenList[i].SetActive(false);
            }
        }

        if (screenIndex > 0)
        {
            leftArrow.SetActive(true);
        }
        else 
        {
            leftArrow.SetActive(false);
        }

        if (screenIndex >= 0 && screenIndex < screenList.Count - 1)
        {
            rightArrow.SetActive(true);
        }
        else
        {
            rightArrow.SetActive(false);
        }
    }
}
