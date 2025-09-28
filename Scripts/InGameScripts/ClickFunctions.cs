using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickFunctions : MonoBehaviour
{

    public GameObject menuBox;
    public bool paused;


    public void menuClick()
    {
        menuBox.SetActive(true);
        paused = true;
    }

    public void Yes()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void No()
    {
        menuBox.SetActive(false);
        paused = false;
    }
}
