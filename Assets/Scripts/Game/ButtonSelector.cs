using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelector : MonoBehaviour
{
    [SerializeField] private Button choice1Button;
    [SerializeField] private Button choice2Button;
    [SerializeField] private Button choice3Button;

    public void SelectButton1(Button button)
    {
        choice1Button.GetComponent<Image>().color = new Color(255, 149, 0, 1);
        choice2Button.GetComponent<Image>().color = Color.white;
        choice3Button.GetComponent<Image>().color = Color.white;
    }

    public void SelectButton2(Button button)
    {
        choice1Button.GetComponent<Image>().color = Color.white;
        choice2Button.GetComponent<Image>().color = new Color(255, 149, 0, 1);
        choice3Button.GetComponent<Image>().color = Color.white;
    }

    public void SelectButton3(Button button)
    {
        choice1Button.GetComponent<Image>().color = Color.white;
        choice2Button.GetComponent<Image>().color = Color.white;
        choice3Button.GetComponent<Image>().color = new Color(255, 149, 0, 1);
    }

    public void UnSelect()
    {
        choice1Button.GetComponent<Image>().color = Color.white;
        choice2Button.GetComponent<Image>().color = Color.white;
        choice3Button.GetComponent<Image>().color = Color.white;
    }
}
