using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_awards : MonoBehaviour
{
    public Button wstecz;
    public GameObject ball;
    public Button plazowa;
    public Button domyslna;
    public Button koszykowka;
    public Button nozna;
    public Button tennis;
    public Button golf;
    
	
	void Start ()
    {
        wstecz = wstecz.GetComponent<Button>();
        plazowa = plazowa.GetComponent<Button>();
        domyslna = domyslna.GetComponent<Button>();
        koszykowka = koszykowka.GetComponent<Button>();
        nozna = nozna.GetComponent<Button>();
        tennis = tennis.GetComponent<Button>();
        golf = golf.GetComponent<Button>();
    }


    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("MENU");
    }

    public void przycisk_domyslna()
    {
        PlayerPrefs.SetInt("ball", 0);
    }

    public void przycisk_plazowa()
    {
        PlayerPrefs.SetInt("ball", 1);
    }

    public void przycisk_koszykowka()
    {
        PlayerPrefs.SetInt("ball", 2);
    }

    public void przycisk_nozna()
    {
        PlayerPrefs.SetInt("ball", 3);
    }

    public void przycisk_tennis()
    {
        PlayerPrefs.SetInt("ball", 4);
    }

    public void przycisk_golf()
    {
        PlayerPrefs.SetInt("ball", 5);
    }

}
