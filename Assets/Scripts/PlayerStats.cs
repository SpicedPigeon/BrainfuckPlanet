﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats {

    public static int playerHealth;

    public static int playerScore;

    public static LinkedList<Weapon> weaponList;

    public static int currency;

    public static void reset()
    {
        playerHealth = 100;
        playerScore = 0;
        currency = 0;
        MeleeWeapon pickaxe = new MeleeWeapon();
        weaponList.AddFirst(pickaxe);
        
    }


}
