using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas quit_menu;
    public Button btn_graj;
    public Button btn_nagrody;
    public Button btn_opcje;
    public Button btn_wyjscie;
    public Button btn_info;

    private Canvas MenuUI;

	void Start ()
    {
        MenuUI = (Canvas)GetComponent<Canvas>();
        quit_menu = quit_menu.GetComponent<Canvas>();
        btn_graj = btn_graj.GetComponent<Button>();
        btn_nagrody = btn_nagrody.GetComponent<Button>();
        btn_opcje = btn_opcje.GetComponent<Button>();
        btn_wyjscie = btn_wyjscie.GetComponent<Button>();
        btn_info = btn_info.GetComponent<Button>();

        quit_menu.enabled = false;

        Cursor.visible = MenuUI.enabled;
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	
	void Update ()
    {
		if(Input.GetKeyUp(KeyCode.Escape))
        {
            MenuUI.enabled = !MenuUI.enabled;
            Cursor.visible = MenuUI.enabled;

            if(MenuUI.enabled)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
	}

    //nacisniecie przycisku "GRAJ"
    public void przycisk_graj()
    {
        SceneManager.LoadScene("Levels");
    }

    public void przycisk_nagrody()
    {
        SceneManager.LoadScene("Awards");
    }

    //nacisniecie przycisku "OPCJE"
    public void przycisk_opcje()
    {
        SceneManager.LoadScene("Options");
    }

    //nacisniecie przycisku "Informacje o grze"
    public void przycisk_info()
    {
        SceneManager.LoadScene("Info_o_grze");
    }

    //nacisniecie przycisku "WYJSCIE"
    public void przycisk_wyjscie()
    {
        quit_menu.enabled = true;
        btn_graj.enabled = false;
        btn_nagrody.enabled = false;
        btn_opcje.enabled = false;
        btn_info.enabled = false;
        btn_wyjscie.enabled = false;
    }

    public void przycisk_wyjscie_tak()
    {
        Application.Quit();
    }
    public void przycisk_wyjscie_nie()
    {
        quit_menu.enabled = false;
        btn_graj.enabled = true;
        btn_nagrody.enabled = true;
        btn_opcje.enabled = true;
        btn_info.enabled = true;
        btn_wyjscie.enabled = true;
    }
}
