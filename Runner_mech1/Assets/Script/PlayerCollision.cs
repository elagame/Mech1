using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision Col)
    {
        if (Col.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            Debug.Log("hit");
        }


    }
}
