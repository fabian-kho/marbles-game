using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float liftHeight;

    private bool isActive;

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            var newPos = transform.position;
            newPos.y += 0.01f;
            transform.position = newPos;
        }
        if (transform.position.y > liftHeight)
        {
            isActive = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateLift();
        }
    }

    public void ActivateLift()
    {
        isActive = true;
    }
}
