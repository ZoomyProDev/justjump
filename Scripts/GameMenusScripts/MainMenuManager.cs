using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    private void Awake()
    {
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {
            PlayerPrefs.SetInt("level", 1);
        }

        if (PlayerPrefs.GetInt("Deaths", 0) == 0)
        {
            PlayerPrefs.SetInt("Deaths", 0);
        }

        if (PlayerPrefs.GetInt("Jumps", 0) == 0)
        {
            PlayerPrefs.SetInt("Jumps", 0);
        }

        if (PlayerPrefs.GetInt("TotalStars", 0) == 0)
        {
            PlayerPrefs.SetInt("TotalStars", 0);
        }

        if (PlayerPrefs.GetInt("EnemiesKilled", 0) == 0)
        {
            PlayerPrefs.SetInt("EnemiesKilled", 0);
        }

        if (PlayerPrefs.GetInt("GravitySwitches", 0) == 0)
        {
            PlayerPrefs.SetInt("GravitySwitches", 0);
        }

        if (PlayerPrefs.GetInt("DoorsUnlocked", 0) == 0)
        {
            PlayerPrefs.SetInt("DoorsUnlocked", 0);
        }

        if (PlayerPrefs.GetInt("TimesTeleported", 0) == 0)
        {
            PlayerPrefs.SetInt("TimesTeleported", 0);
        }
    }

    public void Play()
    {

        SceneManager.LoadScene("PlayMenu");
        
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Skins()
    {
        SceneManager.LoadScene("Skins");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Extras()
    {
        SceneManager.LoadScene("Extras");
    }
}
