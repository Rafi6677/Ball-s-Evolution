using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Awards_system : MonoBehaviour
{
    public string level_name;
    public Button button;
    

	
	void Start ()
    {
        if (PlayerPrefs.GetInt(level_name + "_award", 0) == 0)
        {
            button.enabled = false;
        }
        else
        {
            button.enabled = true;
        }
    }

}
