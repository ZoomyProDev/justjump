using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelManager : MonoBehaviour
{
    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public GameObject nextLevelButton;

    public int totalStars;

    private int level;

    public Text levelComplete;

    private void Awake()
    {

        totalStars = 0;

        if (PlayerPrefs.GetInt("Level1Stars", 0) == 1)
        {
            totalStars++;

        }
        else if (PlayerPrefs.GetInt("Level1Stars") == 2)
        {
            totalStars += 2;

        }
        else if (PlayerPrefs.GetInt("Level1Stars") == 3)
        {
            totalStars += 3;
            
        }

        if (PlayerPrefs.GetInt("Level2Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level2Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level2Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level3Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level3Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level3Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level4Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level4Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level4Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level5Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level5Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level5Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level6Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level6Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level6Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level7Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level7Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level7Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level8Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level8Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level8Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level9Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level9Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level9Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level10Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level10Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level10Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level11Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level11Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level11Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level12Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level12Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level12Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level13Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level13Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level13Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level14Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level14Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level14Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level15Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level15Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level15Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level16Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level16Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level16Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level17Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level17Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level17Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level18Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level18Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level18Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level19Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level19Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level19Stars") == 3)
        {
            totalStars += 3;
        }

        if (PlayerPrefs.GetInt("Level20Stars", 0) == 1)
        {
            totalStars++;
        }
        else if (PlayerPrefs.GetInt("Level20Stars") == 2)
        {
            totalStars += 2;
        }
        else if (PlayerPrefs.GetInt("Level20Stars") == 3)
        {
            totalStars += 3;
        }


        PlayerPrefs.SetInt("TotalStars", totalStars);



        if (PlayerPrefs.GetInt("lastSceneNum") == PlayerPrefs.GetInt("level"))
        {
            if (PlayerPrefs.GetInt("level", 1) < 2)
            {
                PlayerPrefs.SetInt("level", 2);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 3)
            {
                PlayerPrefs.SetInt("level", 3);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 4)
            {
                PlayerPrefs.SetInt("level", 4);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 5)
            {
                PlayerPrefs.SetInt("level", 5);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 6)
            {
                PlayerPrefs.SetInt("level", 6);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 7)
            {
                PlayerPrefs.SetInt("level", 7);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 8)
            {
                PlayerPrefs.SetInt("level", 8);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 9)
            {
                PlayerPrefs.SetInt("level", 9);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 10)
            {
                PlayerPrefs.SetInt("level", 10);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 11)
            {
                PlayerPrefs.SetInt("level", 11);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 12)
            {
                PlayerPrefs.SetInt("level", 12);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 13)
            {
                PlayerPrefs.SetInt("level", 13);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 14)
            {
                PlayerPrefs.SetInt("level", 14);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 15)
            {
                PlayerPrefs.SetInt("level", 15);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 16)
            {
                PlayerPrefs.SetInt("level", 16);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 17)
            {
                PlayerPrefs.SetInt("level", 17);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 18)
            {
                PlayerPrefs.SetInt("level", 18);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 19)
            {
                PlayerPrefs.SetInt("level", 19);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 20)
            {
                PlayerPrefs.SetInt("level", 20);
            }
            else if (PlayerPrefs.GetInt("level", 1) < 21)
            {
                PlayerPrefs.SetInt("level", 21);
            }
        }
        
    }

    private void Start()
    {
        nextLevelButton.SetActive(true);

        if (PlayerPrefs.GetString("lastScene") == "Level1")
        {
            level = 1;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level2")
        {
            level = 2;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level3")
        {
            level = 3;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level4")
        {
            level = 4;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level5")
        {
            level = 5;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level6")
        {
            level = 6;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level7")
        {
            level = 7;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level8")
        {
            level = 8;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level9")
        {
            level = 9;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level10")
        {
            level = 10;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level11")
        {
            level = 11;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level12")
        {
            level = 12;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level13")
        {
            level = 13;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level14")
        {
            level = 14;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level15")
        {
            level = 15;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level16")
        {
            level = 16;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level17")
        {
            level = 17;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level18")
        {
            level = 18;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level19")
        {
            level = 19;
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level20")
        {
            level = 20;
            nextLevelButton.SetActive(false);
        }


        levelComplete.text = " Level " + level.ToString() + "  Complete!";

        oneStar.SetActive(false);
        twoStar.SetActive(false);
        threeStar.SetActive(false);

        if (PlayerPrefs.GetInt("lastStars") == 3)
        {
            threeStar.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("lastStars") == 2)
        {
            twoStar.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("lastStars") == 1)
        {
            oneStar.SetActive(true);
        }
        else 
        {
            
        }
    }

    public void Next()
    {

        if (PlayerPrefs.GetString("lastScene") == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level3")
        {
            SceneManager.LoadScene("Level4");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level4")
        {
            SceneManager.LoadScene("Level5");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level5")
        {
            SceneManager.LoadScene("Level6");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level6")
        {
            SceneManager.LoadScene("Level7");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level7")
        {
            SceneManager.LoadScene("Level8");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level8")
        {
            SceneManager.LoadScene("Level9");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level9")
        {
            SceneManager.LoadScene("Level10");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level10")
        {
            SceneManager.LoadScene("Level11");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level11")
        {
            SceneManager.LoadScene("Level12");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level12")
        {
            SceneManager.LoadScene("Level13");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level13")
        {
            SceneManager.LoadScene("Level14");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level14")
        {
            SceneManager.LoadScene("Level15");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level15")
        {
            SceneManager.LoadScene("Level16");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level16")
        {
            SceneManager.LoadScene("Level17");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level17")
        {
            SceneManager.LoadScene("Level18");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level18")
        {
            SceneManager.LoadScene("Level19");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level19")
        {
            SceneManager.LoadScene("Level20");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level20")
        {
            
        }
    }

    public void Retry()
    {
        if (PlayerPrefs.GetString("lastScene") == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level2")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level3")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level4")
        {
            SceneManager.LoadScene("Level4");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level5")
        {
            SceneManager.LoadScene("Level5");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level6")
        {
            SceneManager.LoadScene("Level6");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level7")
        {
            SceneManager.LoadScene("Level7");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level8")
        {
            SceneManager.LoadScene("Level8");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level9")
        {
            SceneManager.LoadScene("Level9");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level10")
        {
            SceneManager.LoadScene("Level10");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level11")
        {
            SceneManager.LoadScene("Level11");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level12")
        {
            SceneManager.LoadScene("Level12");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level13")
        {
            SceneManager.LoadScene("Level13");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level14")
        {
            SceneManager.LoadScene("Level14");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level15")
        {
            SceneManager.LoadScene("Level15");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level16")
        {
            SceneManager.LoadScene("Level16");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level17")
        {
            SceneManager.LoadScene("Level17");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level18")
        {
            SceneManager.LoadScene("Level18");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level19")
        {
            SceneManager.LoadScene("Level19");
        }
        else if (PlayerPrefs.GetString("lastScene") == "Level20")
        {
            SceneManager.LoadScene("Level20");
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
