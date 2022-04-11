using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    // SerializeField: im Inspektor sichtbar machen
    [SerializeField] private UnityEvent PressedEvent;
    [SerializeField] private GameObject TargetPlatform;
    [SerializeField] private AudioClip buttonSfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Sound abspielen
            AudioSource.PlayClipAtPoint(buttonSfx, Camera.main.transform.position);
            // verknüpftes Event auslösen
            PressedEvent.Invoke();
        }
    }
}
