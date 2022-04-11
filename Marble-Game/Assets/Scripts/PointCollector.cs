using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    public AudioClip pickUpsound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Point"))
        {
            AudioSource.PlayClipAtPoint(pickUpsound, Camera.main.transform.position);
            Destroy(other.gameObject);
        }          
    }
}
