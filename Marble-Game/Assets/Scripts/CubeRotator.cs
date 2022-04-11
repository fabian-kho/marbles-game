using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public float anglePerFrame = 0.1f;

    protected Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var amount = anglePerFrame * Time.deltaTime;
        transform.Rotate(Vector3.up, amount, Space.World);
       
    }
}
 