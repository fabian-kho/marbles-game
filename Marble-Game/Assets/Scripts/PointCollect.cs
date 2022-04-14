using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollect : MonoBehaviour
{
    public AudioClip pickUpSound;



    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(pickUpSound, Camera.main.transform.localPosition);
        }
        
    }
}
