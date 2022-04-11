using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement: MonoBehaviour
{
    // Start is called before the first frame update
    public float maxG = 20f;
    public float anglePerInputSecond = 10f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_Input = Input.GetAxis("Vertical");
        float horizontal_Input = Input.GetAxis("Horizontal");
        Vector3 rotateVectorNormalized = new Vector3(vertical_Input, 0, horizontal_Input).normalized;
        if (transform.rotation.x > 20 || transform.rotation.z > 20 || transform.rotation.x < -20 || transform.rotation.z < -20)
        {
            transform.Rotate(rotateVectorNormalized * anglePerInputSecond * Time.deltaTime, Space.World);
        }

    }
}
