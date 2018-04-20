using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_crystals : MonoBehaviour
{
    public Text Crystals_left;
    private Canvas HUD_UI;
    //public int how_many_crystals;

    void Start ()
    {
        HUD_UI = (Canvas)GetComponent<Canvas>();
    }
	
	
	void Update ()
    {
        Crystals_left.text = leave_crystals().ToString();
    }

    int leave_crystals()
    {
        Crystals[] how_many = Component.FindObjectsOfType<Crystals>();
        return how_many.Length;
    }
}
