using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    //Vector3 velocity = new Vector3 (3f, 0f, 0f);
    //Vector3 start_position;

    void Start()
    {
        //start_position = transform.position;
    }


    void Update()
    {
        //Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        //rigidbody.position = velocity;

        float velocity = Time.deltaTime * 2f;
        transform.Translate(-velocity, 0f, 0f);
    }
}
