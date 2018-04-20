using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_options_sound : MonoBehaviour
{
    public AudioMixer master_mixer;
    public Button wstecz;

    public void music_vol(float music_lvl)
    {
        master_mixer.SetFloat("MuzykaVol", music_lvl);
    }

    public void przycisk_wstecz()
    {
        SceneManager.LoadScene("Options");
    }
}
