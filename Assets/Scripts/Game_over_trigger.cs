using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_over_trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "sphere")
        {
            string LevelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(LevelName);
        }
    }
}
