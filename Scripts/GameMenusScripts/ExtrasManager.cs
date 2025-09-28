using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtrasManager : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.SetInt("Speedrun", 0);
    }

    public void Stats()
    {
        SceneManager.LoadScene("Stats");
    }

    public void Speedrun()
    {

        SceneManager.LoadScene("Speedrun1");
        PlayerPrefs.SetInt("Speedrun", 1);
        

    }

    public void MyBestTimes()
    {
        SceneManager.LoadScene("BestTimes");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
