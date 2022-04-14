using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    [SerializeField] CharacterStats stats;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hole"))
        {
            stats.Initialize();
        }
        if (other.CompareTag("Points")){
            //stats.highScore++;
            ScoreManager.instance.AddPoint();
        }
    }

}
