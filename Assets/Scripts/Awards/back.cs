using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public Button zamknij;

    void Start()
    {
        zamknij = zamknij.GetComponent<Button>();
    }

    public void przycisk_zamknij()
    {
        SceneManager.LoadScene("MENU");
    }
}
