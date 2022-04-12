using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float anglePerFrame = 0.1f;

    protected Rigidbody rb;
   

    // Update is called once per frame
    void Update()
    {
        var amount = anglePerFrame * Time.deltaTime;
        transform.Rotate(Vector3.up, amount, Space.World);
    }
}