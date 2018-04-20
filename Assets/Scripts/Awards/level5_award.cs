using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level5_award : MonoBehaviour {

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "sphere" && leave_crystals() == 0)
        {
            string level_name = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(level_name + "_finished", 1);
            PlayerPrefs.SetInt(level_name + "_award", 1);

            SceneManager.LoadScene("level_award");
        }
    }

    int leave_crystals()
    {
        Crystals[] how_many = Component.FindObjectsOfType<Crystals>();
        return how_many.Length;
    }
}
