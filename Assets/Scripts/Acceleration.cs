using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public bool right_direction = true;
    public bool up = false;
    public bool down = false;

    private void OnTriggerStay(Collider collision)
    {
        GameObject thing = collision.gameObject;
        Rigidbody rigidbody = thing.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;

        if (right_direction)
        {
            velocity.z = 10f;
        }
        else
        {
            if (up)
            {
                velocity.x = -10f;
            }
            else
            {
                if(down)
                {
                    velocity.x = 10f;
                }
                else
                {
                    velocity.z = -10f;
                }
            }
        }
        
        rigidbody.velocity = velocity;
    }
}
