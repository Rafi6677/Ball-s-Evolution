using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu_options : MonoBehaviour
{
    public Canvas questionUI;

    public GameObject ball;
    public Texture main;
    public Button wstecz;
    public Button sterowanie;
    public Button dzwiek;
    public Button reset;
    public Button question_tak;
    public Button question_nie;
    private Canvas OptionsUI;

    void Start ()
    {
        OptionsUI = (Canvas)GetComponent<Canvas>();
        questionUI = questionUI.GetComponent<Canvas>();

        wstecz = wstecz.GetComponent<Button>();
        sterowanie = sterowanie.GetComponent<Button>();
        dzwiek = dzwiek.GetComponent<Button>();
        reset = reset.GetComponent<Button>();

        questionUI.enabled = false;
    }
	

    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("MENU");
    }

    public void przycisk_sterowanie()
    {
        SceneManager.LoadScene("Options_movement");
    }

    public void przycisk_dzwiek()
    {
        SceneManager.LoadScene("Options_sound");
    }

    public void przycisk_reset()
    {
        questionUI.enabled = true;
        wstecz.enabled = false;
        sterowanie.enabled = false;
        dzwiek.enabled = false;
        reset.enabled = false;
    }

    public void tak()
    {
        PlayerPrefs.DeleteAll();
        ball.GetComponent<Renderer>().sharedMaterial.mainTexture = main;
        questionUI.enabled = false;
        wstecz.enabled = true;
        sterowanie.enabled = true;
        dzwiek.enabled = true;
        reset.enabled = true;
    }

    public void nie()
    {
        questionUI.enabled = false;
        wstecz.enabled = true;
        sterowanie.enabled = true;
        dzwiek.enabled = true;
        reset.enabled = true;
    }
}
