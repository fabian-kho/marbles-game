using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        
        Movement component = other.gameObject.GetComponent<Movement>();
        if(component != null){

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
