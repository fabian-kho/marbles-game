using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotator : MonoBehaviour
{
    public float anglePerInputSecond = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_Input = Input.GetAxis("Horizontal");
        Vector3 rotateVectorNormalized = new Vector3(0, 0, horizontal_Input).normalized;        
        transform.Rotate(rotateVectorNormalized * anglePerInputSecond * Time.deltaTime, Space.World);
    }
}
