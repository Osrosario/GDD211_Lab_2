using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cpuPlayer;

    private WeaponHolder plyrWeapons;
    private CpuWeapons cpuWeapons;

    private float delay = 1f;
    private float delayReset = 0.5f;
    private int index;

    private void Start()
    {
        plyrWeapons = player.GetComponent<WeaponHolder>();
        cpuWeapons = cpuPlayer.GetComponent<CpuWeapons>();
    }

    public void Battler()
    {
        plyrWeapons.AssignImage(index);
        cpuWeapons.AssignImage(index);

        CompareWeapons(plyrWeapons.GetWeapons()[index], cpuWeapons.GetWeapons()[index]);
    }

    private void ShowNextMove()
    {
        if (delay <= 0)
        {
            // Show move
            delay = delayReset;
        }
    }

    private void CompareWeapons(string plyrWeapon, string cpuWeapon)
    {
        if (plyrWeapon == "Sword" && cpuWeapon == "Sword")
        {

        }
    }


    private void Update()
    {
        delay -= Time.deltaTime;
        ShowNextMove();
    }




}
