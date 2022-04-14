using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        
        Movement component = other.gameObject.GetComponent<Movement>();
        if(component != null){
            LevelChanger.Load(LevelChanger.Scene.Level2);    
        }
    }
}

