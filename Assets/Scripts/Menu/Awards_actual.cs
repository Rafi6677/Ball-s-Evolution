using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Awards_actual : MonoBehaviour
{
    public Text actual_ball;
    

    void Start()
    {
        if (PlayerPrefs.GetInt("ball", 0) == 0)
        {
            actual_ball.text = "domyślna";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 1)
        {
            actual_ball.text = "plażowa";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 2)
        {
            actual_ball.text = "koszykówka";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 3)
        {
            actual_ball.text = "piłka nożna";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 4)
        {
            actual_ball.text = "tennis";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 5)
        {
            actual_ball.text = "golf";
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("ball", 0) == 0)
        {
            actual_ball.text = "domyślna";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 1)
        {
            actual_ball.text = "plażowa";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 2)
        {
            actual_ball.text = "koszykówka";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 3)
        {
            actual_ball.text = "piłka nożna";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 4)
        {
            actual_ball.text = "tennis";
        }
        if (PlayerPrefs.GetInt("ball", 0) == 5)
        {
            actual_ball.text = "golf";
        }
    }
}
