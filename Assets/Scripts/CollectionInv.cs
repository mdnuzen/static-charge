using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Keeps track of how many candies are collected

public class CollectionInv : MonoBehaviour
{

    // Other scripts can read int value, but only this script can set value
    public int NumberOfBolts;
    
    // Updates the amount of candies collected
    public void BoltCollected()
    {
        NumberOfBolts++;
    }
}