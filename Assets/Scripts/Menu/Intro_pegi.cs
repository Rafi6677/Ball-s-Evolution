﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro_pegi : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Intro");
    }
}
