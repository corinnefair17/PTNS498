using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDice : MonoBehaviour
{
    public int roll(int numSides, int numDice, int mod)
    {
        System.Random r = new System.Random();
        int total = 0;
        for (int i = 0; i < numDice; i++)
        {
            total += r.Next(1, numSides) + mod;
        }
        return total;
    }
}
