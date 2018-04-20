using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape_To_Menu : MonoBehaviour
{
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MENU");
        }
	}
}
