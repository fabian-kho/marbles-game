using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Referenz auf den Rigidbody
    public Rigidbody rb;

    //Speed of Marble
    public float moveSpeed= 10f;

    private float xInput;
    private float zInput;

    private void Start()
    {
        // Rigidbody Referenz einmalig beim Start anlegen
        // ... GetComponent<> ist eine teure Operation,
        // und sollte wenn möglich nicht in den Updates benutzt werden
        rb= GetComponent<Rigidbody>();
    }

    // Für physikalische Updates.
    /*private void FixedUpdate()
    {


        // Kamera Vektor in x/z Richtung
        var fw = Camera.main.transform.forward;
        fw.y = 0;
        var right = Camera.main.transform.right;
        right.y = 0;

        // Bewegungsvektor ausrechnen
        var mv = h * right + v * fw;
        mv.Normalize();

        // Kraft auf Rigidbody ausüben
        
    }*/

    // Für Spielelogik-Update - wird hier nicht benötigt.
    void Update()
    {
        ProcessInput();
    }
    
    private void FixedUpdate(){

        Move();

    }

    private void ProcessInput(){

        // Spielereingabe abrufen
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }

    private void Move(){

        rb.AddForce(new Vector3(xInput,0f, zInput)* moveSpeed);

    }
}
