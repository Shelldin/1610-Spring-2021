using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehaviour : MonoBehaviour
{
    public int number, total;
    public string[] fruits;
    public WeaponSO[] weapons;
    
    
    private void Start()
    {
        for (int i = 0; i < number; i++)
        {
            total = i;
            print(total);
        }

        foreach (var fruit in fruits)
        {
            print("I like to eat " + fruit);
        }

        foreach (var weapon in weapons)
        {
            print("You have my " + weapon.name + ", with a value of " + weapon.powerLevel);
        }
    }
}
