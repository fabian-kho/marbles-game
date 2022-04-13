using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorScript : MonoBehaviour
{
    bool rotation = false;
    private float rotationAngle = -90;
    private void FixedUpdate()
    {
        if (rotation)
        {
            Quaternion endpunkt = Quaternion.Euler(0, 0, rotationAngle);
            transform.rotation = Quaternion.Lerp(transform.rotation, endpunkt, Time.deltaTime);
        }
    }


    public void Drop()
    {
        rotation = true;
    }
}
