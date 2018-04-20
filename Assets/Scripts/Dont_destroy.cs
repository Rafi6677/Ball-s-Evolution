using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_destroy : MonoBehaviour
{
	void Start ()
    {
        DontDestroyOnLoad(gameObject);
	}
}
