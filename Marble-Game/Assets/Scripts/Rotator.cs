using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool isEnabled = false;
    public float rotationSpeed = 1.0f;
    //bool wasTouched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            transform.Rotate(Vector3.forward * rotationSpeed, Space.World);
        }
    }    
}
