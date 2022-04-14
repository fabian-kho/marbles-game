using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        
        Movement component = other.gameObject.GetComponent<Movement>();
        if(component != null){
            LevelManager.Load(LevelManager.Scene.Level2);    
        }
    }
}

