using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    [Header("Reference(s)")]
    [SerializeField] private GameObject playerSpr;
    [SerializeField] private GameObject cpuSpr;

    [Header("Start and Confirm Buttons")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button confirmButton;

    [Header("Choice Buttons")]
    [SerializeField] private Button attackButton;
    [SerializeField] private Button shieldButton;
    [SerializeField] private Button chargeButton;
    [SerializeField] private Button attackPButton;

    [Header("Choice Images")]
    [SerializeField] private List<Image> choiceImages;

    [Header("Delay Settings")]
    [SerializeField] private float delay;
    [SerializeField] private float delayReset;

    private PlayerWeapons player;
    private CpuWeapons cpu;
    private int battleCounter = 0;
    private bool battle = false;
    private bool isBattleDone = false;

    private void Start()
    {
        player = playerSpr.GetComponent<PlayerWeapons>();
        cpu = cpuSpr.GetComponent<CpuWeapons>();
    }

    private void ClearImages()
    {
        foreach (Image image in choiceImages)
        {
            image.color = new Color(image.color.r, image.color.b, image.color.g, 0);
            image.sprite = null;
        }
    }

    private void EnableChoices()
    {
        attackButton.interactable = true;
        shieldButton.interactable = true;

        if (player.GetChargeState())
        {
            attackPButton.interactable = true;
        }
        else
        {
            chargeButton.interactable = true;
        }
    }

    public void DisableChoices()
    {
        attackButton.interactable = false;
        shieldButton.interactable = false;
        chargeButton.interactable = false;
        attackPButton.interactable = false;
    }

    public void BattleStart()
    {
        CheckWeapons();
        battle = true;
    }

    private void CheckWeapons()
    {
        if (player.GetWeapons().Contains("charge"))
        {
            player.SetChargeState(true);
        }
        else if (player.GetWeapons().Contains("swordPowered"))
        {
            player.SetChargeState(false);
        }

        if (cpu.GetWeapons().Contains("charge"))
        {
            cpu.SetChargeState(true);
        }
        else if (cpu.GetWeapons().Contains("swordPowered"))
        {
            cpu.SetChargeState(false);
        }
    }

    public void Battle()
    {
        player.AssignImage(battleCounter);
        cpu.AssignImage(battleCounter);

        CompareWeapons(player.GetWeapons()[battleCounter], cpu.GetWeapons()[battleCounter]);

        isBattleDone = true;
    }

    private void ResetGame()
    {
        player.EmptyWeaponList();
        cpu.ClearWeaponList();
        ClearImages();
        EnableChoices();
        startButton.interactable = false;
        confirmButton.interactable = true;
        battleCounter = 0;
        battle = false;
    }

    private void CompareWeapons(string plyrWeapon, string cpuWeapon)
    {
        if (plyrWeapon == "sword" && cpuWeapon == "sword")
        {
            player.takeDamage(5);
            cpu.takeDamage(5);
        }
        else if (plyrWeapon == "sword" && cpuWeapon == "charge")
        {
            cpu.takeDamage(10);
        }
        else if (plyrWeapon == "sword" && cpuWeapon == "swordPowered")
        {
            player.takeDamage(15);
            cpu.takeDamage(5);
        }
        else if (plyrWeapon == "swordPowered" && cpuWeapon == "sword")
        {
            player.takeDamage(5);
            cpu.takeDamage(15);
        }
        else if (plyrWeapon == "swordPowered" && cpuWeapon == "shield")
        {
            cpu.takeDamage(10);
        }
        else if (plyrWeapon == "swordPowered" && cpuWeapon == "charge")
        {
            cpu.takeDamage(15);
        }
        else if (plyrWeapon == "swordPowered" && cpuWeapon == "swordPowered")
        {
            player.takeDamage(10);
            cpu.takeDamage(10);
        }
        else if (cpuWeapon == "sword" && plyrWeapon == "charge")
        {
            player.takeDamage(10);
        }
        else if (cpuWeapon == "sword" && plyrWeapon == "swordPowered")
        {
            cpu.takeDamage(15);
            player.takeDamage(5);
        }
        else if (cpuWeapon == "swordPowered" && plyrWeapon == "sword")
        {
            cpu.takeDamage(5);
            player.takeDamage(15);
        }
        else if (cpuWeapon == "swordPowered" && plyrWeapon == "shield")
        {
            player.takeDamage(10);
        }
        else if (cpuWeapon == "swordPowered" && plyrWeapon == "charge")
        {
            player.takeDamage(15);
        }
    }

    private void Update()
    {       
        if (battle)
        {
            if (!isBattleDone)
            {
                Battle();
            }
            
            delay -= Time.deltaTime;
        }

        if (delay <= 0)
        {
            battleCounter++;
            isBattleDone = false;
            delay = delayReset;
        }

        if (battleCounter >= 3)
        {
            ResetGame();
        }

        if (player.GetHealth() <= 0)
        {
            SceneManager.LoadScene(3);
        }
        
        if (cpu.GetHealth() <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
