using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    [SerializeField] CharacterStats stats;

    private void OnTriggerEnter(Collider other)
    {
        stats.collisionCount += 1;
    }
}
