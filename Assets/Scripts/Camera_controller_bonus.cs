using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller_bonus : MonoBehaviour {

    public Transform sphere;

    void Update()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(1f, 15f, 0f);
        //float velocity = rigidbody.velocity.sqrMagnitude;
        //vector = vector * (1f + velocity / 25f);

        Vector3 newPosition = sphere.position + vector;
        //transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 2f);
        transform.position = newPosition;
       
        transform.LookAt(sphere);
    }
}
