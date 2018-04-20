using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_info : MonoBehaviour
{
    private Canvas InfoUI;
    public Button wstecz;

    void Start ()
    {
        InfoUI = (Canvas)GetComponent<Canvas>();
        wstecz = wstecz.GetComponent<Button>();
    }

    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("MENU");
    }
}
