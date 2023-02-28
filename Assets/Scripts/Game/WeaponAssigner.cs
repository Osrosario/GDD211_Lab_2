using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponAssigner : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private GameObject sceneMaster;
    [SerializeField] private GameObject playerSpr;
    [SerializeField] private GameObject cpuSpr;

    [Header("Start Button")]
    [SerializeField] private Button startButton;

    [Header("Player Choices")]
    [SerializeField] private Image choice1Spr;
    [SerializeField] private Image choice2Spr;
    [SerializeField] private Image choice3Spr;

    private StartBattle battle;
    private ButtonSelector buttons;
    private PlayerWeapons plyrWeapons;
    private CpuWeapons cpuWeapons;

    private void Start()
    {
        battle = sceneMaster.GetComponent<StartBattle>();
        buttons = sceneMaster.GetComponent<ButtonSelector>();
        plyrWeapons = playerSpr.GetComponent<PlayerWeapons>();
        cpuWeapons = cpuSpr.GetComponent<CpuWeapons>();
    }

    public void AssignWeapons()
    {
        plyrWeapons.AssignSprite(choice1Spr.sprite);
        plyrWeapons.AssignSprite(choice2Spr.sprite);
        plyrWeapons.AssignSprite(choice3Spr.sprite);

        cpuWeapons.AssignWeapons();

        battle.DisableChoices();
        buttons.UnSelect();
        startButton.interactable = true;
        gameObject.GetComponent<Button>().interactable = false;

        for (int i = 0; i < cpuWeapons.GetWeapons().Count; i++)
        {
            Debug.Log(cpuWeapons.GetWeapons()[i]);
        }
    }
}
