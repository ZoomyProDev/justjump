using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void Back()
    {
        if (PlayerPrefs.GetInt("Speedrun") == 1)
        {
            SceneManager.LoadScene("Speedrun2");
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void Level1()
    {
        if(PlayerPrefs.GetInt("level", 1) >= 1)
        {
            SceneManager.LoadScene("Level1");
        }
        
    }
    public void Level2()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void Level3()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 3)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    public void Level4()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 4)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    public void Level5()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 5)
        {
            SceneManager.LoadScene("Level5");
        }
    }
    public void Level6()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 6)
        {
            SceneManager.LoadScene("Level6");
        }
    }
    public void Level7()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 7)
        {
            SceneManager.LoadScene("Level7");
        }
    }
    public void Level8()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 8)
        {
            SceneManager.LoadScene("Level8");
        }
    }
    public void Level9()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 9)
        {
            SceneManager.LoadScene("Level9");
        }
    }
    public void Level10()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 10)
        {
            SceneManager.LoadScene("Level10");
        }
    }
    public void Level11()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 11)
        {
            SceneManager.LoadScene("Level11");
        }
    }
    public void Level12()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 12)
        {
            SceneManager.LoadScene("Level12");
        }
    }
    public void Level13()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 13)
        {
            SceneManager.LoadScene("Level13");
        }
    }
    public void Level14()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 14)
        {
            SceneManager.LoadScene("Level14");
        }
    }
    public void Level15()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 15)
        {
            SceneManager.LoadScene("Level15");
        }
    }
    public void Level16()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 16)
        {
            SceneManager.LoadScene("Level16");
        }
    }
    public void Level17()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 17)
        {
            SceneManager.LoadScene("Level17");
        }
    }
    public void Level18()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 18)
        {
            SceneManager.LoadScene("Level18");
        }
    }
    public void Level19()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 19)
        {
            SceneManager.LoadScene("Level19");
        }
    }
    public void Level20()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 20)
        {
            SceneManager.LoadScene("Level20");
        }
    }
}
