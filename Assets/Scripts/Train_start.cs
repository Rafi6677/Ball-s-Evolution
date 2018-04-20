using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train_start : MonoBehaviour {

    public GameObject train;
    bool active = false;
    public bool up = true;

    private void Update()
    {
        if(active)
        {
            float velocity = Time.deltaTime * 2f;
            if(up)
            {
                train.transform.Translate(-velocity, 0f, 0f);
            }
            else
            {
                train.transform.Translate(velocity, 0f, 0f);
            }
        }
    }



    private void OnTriggerEnter(Collider collision)
    { 
        if(collision.gameObject.name == "sphere")
        {
            active = true;
        }
    }
}
