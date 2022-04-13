using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterStats : ScriptableObject
{
   [Header("Spieler Stats")]
    public int points = 0;
    public int initPoints = 0;
    public int health = 10;
    public int initHealth = 10;
    public int collisionCount = 0;
    public int initCollisionCount = 0;

    private void Awake()
    {
        points = initPoints;
        health = initHealth;
        collisionCount = initCollisionCount;
    }
}
