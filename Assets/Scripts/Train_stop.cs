using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train_stop : MonoBehaviour
{
    public GameObject train;
    bool active = false;

    private void Update()
    {
        if (active)
        {
            train.transform.Translate(0f, 0f, 0f);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Train")
        {
            active = true;
        }
    }
}
