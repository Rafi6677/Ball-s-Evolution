using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet_collision : MonoBehaviour {

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "sphere")
        {
            Destroy(gameObject);
            string LevelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(LevelName);
        }
        else
        {
            if(collision.gameObject.tag =="crystal")
            {
                
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
