using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{

    public Toggle sfx;
    public Toggle music;


    private void Start()
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 0)
        {
            sfx.SetIsOnWithoutNotify(true);
            sfx.SetIsOnWithoutNotify(false);
        }
        else if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            sfx.SetIsOnWithoutNotify(false);
            sfx.SetIsOnWithoutNotify(true);
        }
        if (PlayerPrefs.GetInt("MUSIC", 1) == 0)
        {
            music.SetIsOnWithoutNotify(true);
            music.SetIsOnWithoutNotify(false);

        }
        else if (PlayerPrefs.GetInt("MUSIC", 1) == 1)
        {
            music.SetIsOnWithoutNotify(false);
            music.SetIsOnWithoutNotify(true);

        }
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void SFX(bool toggle)
    {
        if (toggle == true)
        {
            PlayerPrefs.SetInt("SFX", 1);
        }
        else if (toggle == false)
        {
            PlayerPrefs.SetInt("SFX", 0);
        }

        
    }

    public void MUSIC(bool toggle)
    {
        if (toggle == true)
        {
            PlayerPrefs.SetInt("MUSIC", 1);
        }
        else if (toggle == false)
        {
            PlayerPrefs.SetInt("MUSIC", 0);
        }
    }

}
