using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool rotation = false;
    private float rotationAngle = -90;
    private void FixedUpdate()
    {
        if (rotation)
        {
            Quaternion endpunkt = Quaternion.Euler(90, rotationAngle, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, endpunkt, Time.deltaTime);
        }
    }


    public void Drop()
    {
        rotation = true;
    }
}

