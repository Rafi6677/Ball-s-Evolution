using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_check : MonoBehaviour
{
    //public TextMesh text_mesh;
    public string level_name;
    public Button lvl;
   
    void Start ()
    {
		if(PlayerPrefs.GetInt(level_name + "_finished", 0) == 0)
        {
            lvl.enabled = false;
        }
        else
        {
            lvl.enabled = true;
        }
	}
	
}
