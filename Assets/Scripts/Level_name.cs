using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_name : MonoBehaviour
{
    public TextMesh textmesh;

    void Start()
    {
        string LevelName = SceneManager.GetActiveScene().name;
        textmesh.text = LevelName;
    }
}
	
	
