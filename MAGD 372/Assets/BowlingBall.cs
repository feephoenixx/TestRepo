using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{

    public Transform ballPosition;
    public Rigidbody ballPhysics;
    public float throwStrength = 1f;
    private bool ballThrown = false;
    private Vector3 mousePos;
    private float clampedMouseX;

    private void Start()
    {
        ballPosition.position = new Vector3(0, -0.5f, -15);
    }

    // Update is called once per frame
    private void Update()
    {
        mousePos = Input.mousePosition;
        clampedMouseX = Mathf.Clamp(mousePos.x, -100, 50);
        if (!ballThrown)
        {
            var pos = ballPosition.position;
            pos.x = Mathf.Clamp(clampedMouseX, -2.3f, 2.3f);
            ballPosition.position = pos;
            
        }
        if (Input.GetMouseButtonDown(0) && !ballThrown)
        {
            ballThrown = true;
            ballPhysics.AddForce(0, 0, throwStrength);
        }
    }
}
