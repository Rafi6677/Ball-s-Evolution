using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name=="sphere" && leave_crystals()==0)
        {
            string level_name = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(level_name + "_finished", 1);
            lvl2_award(level_name);

            SceneManager.LoadScene("Levels");
        }
    }

    int leave_crystals()
    {
        Crystals[] how_many = Component.FindObjectsOfType<Crystals>();
        return how_many.Length;
    }

    void lvl2_award (string level)
    {
        if (level == "level 2")
        {
            PlayerPrefs.SetInt(level + "_award", 1);
        }
    }
}
