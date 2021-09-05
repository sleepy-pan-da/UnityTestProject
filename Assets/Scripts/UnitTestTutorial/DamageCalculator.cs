using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator
{
    public static int CalculateDamage(int amount, float mitigationPercent)
    {
        float multiplierPercent = 1f - mitigationPercent;
        int calculatedDamage = Convert.ToInt32(amount * multiplierPercent);
        return calculatedDamage;
    }

    // doesnt care if it's an actual character, as long as it implements ICharacter
    // no need concrete implementation of Character class
    public static int CalculateDamage(int amount, ICharacter character) 
    {
        int totalArmor = character.Inventory.GetTotalArmor() + (character.Level * 10);
        float multiplier = 100f - totalArmor;
        multiplier /= 100f;
        return Convert.ToInt32(amount * multiplier);
    }
}
