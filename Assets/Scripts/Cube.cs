using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 start_position;

    void Start ()
    {
        start_position = transform.position;
    }


    void Update ()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        if (transform.position.y < -10)
        {
            velocity.x = 0f;
            velocity.y = 0f;
            velocity.z = 0f;
            transform.position = start_position;
            rigidbody.velocity = velocity;
        }
	}
}
