using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private float speed = 5f;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(new Vector3(inputX, 0, inputY) * speed* 2);
        }
        else
        {
            rb.AddForce(new Vector3(inputX, 0, inputY) * speed);
        }
    }
}
