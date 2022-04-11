using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody myRigidbody;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!canMove)
            return;
        float vertical_Input = Input.GetAxis("Vertical");
        float horizontal_Input = Input.GetAxis("Horizontal");
        var camera_forward_vector = Camera.main.transform.forward;
        var camera_right_vector = Camera.main.transform.right;
        Vector3 Force = camera_forward_vector * vertical_Input + camera_right_vector * horizontal_Input;
        Force.y = 0f;
        Force.Normalize();
        myRigidbody.AddForce(Force * speed);
    }

    public void DisableMovement()
    {
        canMove = false;
    }
}
