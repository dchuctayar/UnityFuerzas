using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject ball;
    public Transform cam;
    public float ballDistance = 2f;
    public float ballForce = 250f;
    bool holdingBall = true;
    Rigidbody ballRB;

    bool isPickableBall = false;
    public CanvasController canvasScript;
    public LayerMask pickableLayer;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        ballRB = ball.GetComponent<Rigidbody>();
        ballRB.useGravity = false;
        canvasScript.OcultarCursor(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ballRB.useGravity = true;
                ballRB.AddForce(cam.forward * ballForce);
            }
        }
    }

    // LateUpdate is called after all Update functions have been called
    private void LateUpdate()
    {
        if (holdingBall == true)
        {
            ball.transform.position = cam.position + cam.forward * ballDistance;
        }
    }
}