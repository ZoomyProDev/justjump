using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuManager : MonoBehaviour
{
    public void Continue()
    {

        if (PlayerPrefs.GetInt("level", 1) == 21)
        {
            SceneManager.LoadScene("Level20");

        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
        }

    }

    public void Multiplayer()
    {
        //SceneManager.LoadScene("MultiplayerMenu");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}