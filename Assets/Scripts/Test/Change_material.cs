using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material : MonoBehaviour
{
    public Texture material;
       
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "sphere")
        {
            collision.gameObject.GetComponent<Renderer>().material.mainTexture = material;   
        }
    }
}
