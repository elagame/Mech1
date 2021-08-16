using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rd;
    public float Speed;
    public float Swingspeed;

    // Update is called once per frame
    void Update()
    {
        rd.AddForce(0,0, Speed* Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rd.AddForce(-Swingspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange );

        }
        if (Input.GetKey("d"))
        {
            rd.AddForce(Swingspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
