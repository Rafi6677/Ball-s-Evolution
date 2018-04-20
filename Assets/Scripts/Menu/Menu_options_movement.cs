using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_options_movement : MonoBehaviour
{
    public Button wstecz;
	
	void Start ()
    {
        wstecz = wstecz.GetComponent<Button>();
    }
	
    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("Options");
    }
}
