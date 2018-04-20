using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour
{
    public GameObject particles;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name != "sphere")
        {
            return;
        }
        else
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
        }
    }
}


