using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerMenuManager : MonoBehaviour
{
    public void Racing()
    {

        PlayerPrefs.SetString("MultiplayerMode", "Racing");

        SceneManager.LoadScene("LoadingMultiplayer");

    }

    public void Tag()
    {
        PlayerPrefs.SetString("MultiplayerMode", "Tag");

        SceneManager.LoadScene("LoadingMultiplayer");
    }

    public void Back()
    {
        SceneManager.LoadScene("PlayMenu");
    }

}
