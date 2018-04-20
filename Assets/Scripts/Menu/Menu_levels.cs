using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu_levels : MonoBehaviour
{
    public Button wstecz;
    public Button lvl_1;
    public Button lvl_2;
    public Button lvl_3;
    public Button lvl_4;
    public Button lvl_5;
    public Button lvl_6;
    public Button lvl_7;
    public Button lvl_8;
    public Button lvl_9;
    public Button lvl_10;
    public Button lvl_11;
    public Button lvl_12;
    public Button lvl_13;
    public Button lvl_14;
    public Button lvl_15;
    public Button lvl_16;
    public Button lvl_17;
    public Button lvl_18;


    private Canvas LevelsUI;

    void Start ()
    {
        LevelsUI = (Canvas)GetComponent<Canvas>();
        lvl_1 = lvl_1.GetComponent<Button>();
        lvl_2 = lvl_2.GetComponent<Button>();
        lvl_3 = lvl_3.GetComponent<Button>();
        lvl_4 = lvl_4.GetComponent<Button>();
        lvl_5 = lvl_5.GetComponent<Button>();
        lvl_6 = lvl_6.GetComponent<Button>();
        lvl_7 = lvl_7.GetComponent<Button>();
        lvl_8 = lvl_8.GetComponent<Button>();
        lvl_9 = lvl_9.GetComponent<Button>();
        lvl_10 = lvl_10.GetComponent<Button>();
        lvl_11 = lvl_11.GetComponent<Button>();
        lvl_12 = lvl_12.GetComponent<Button>();
        lvl_13 = lvl_13.GetComponent<Button>();
        lvl_14 = lvl_14.GetComponent<Button>();
        lvl_15 = lvl_15.GetComponent<Button>();
        lvl_16 = lvl_16.GetComponent<Button>();
        lvl_17 = lvl_17.GetComponent<Button>();
        lvl_18 = lvl_18.GetComponent<Button>();

        Cursor.visible = LevelsUI.enabled;
        Cursor.lockState = CursorLockMode.Confined;
    }
	

    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("MENU");
    }

    public void przycisk_level_1()
    {
        SceneManager.LoadScene("level 1");
    }

    public void przycisk_level_2()
    {
        SceneManager.LoadScene("level 2");
    }

    public void przycisk_level_3()
    {
        SceneManager.LoadScene("level 3");
    }

    public void przycisk_level_4()
    {
        SceneManager.LoadScene("level 4");
    }

    public void przycisk_level_5()
    {
        SceneManager.LoadScene("level 5");
    }

    public void przycisk_level_6()
    {
        SceneManager.LoadScene("level 6");
    }

    public void przycisk_level_7()
    {
        SceneManager.LoadScene("level 7");
    }

    public void przycisk_level_8()
    {
        SceneManager.LoadScene("level 8");
    }

    public void przycisk_level_9()
    {
        SceneManager.LoadScene("level 9");
    }

    public void przycisk_level_10()
    {
        SceneManager.LoadScene("level 10");
    }

    public void przycisk_level_11()
    {
        SceneManager.LoadScene("level 11");
    }

    public void przycisk_level_12()
    {
        SceneManager.LoadScene("level 12");
    }

    public void przycisk_level_13()
    {
        SceneManager.LoadScene("level 13");
    }

    public void przycisk_level_14()
    {
        SceneManager.LoadScene("level 14");
    }

    public void przycisk_level_15()
    {
        SceneManager.LoadScene("level 15");
    }

    public void przycisk_level_16()
    {
        SceneManager.LoadScene("level 16");
    }

    public void przycisk_level_17()
    {
        SceneManager.LoadScene("level 17");
    }

    public void przycisk_level_18()
    {
        SceneManager.LoadScene("level 18");
    }
}
