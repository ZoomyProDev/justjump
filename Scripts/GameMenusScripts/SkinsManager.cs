using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinsManager : MonoBehaviour
{
    public GameObject skinOne, skinTwo, skinThree, skinFour, skinFive, skinSix, skinSeven, skinEight, skinNine;

    private void Awake()
    {
        skinOne.transform.GetChild(0).gameObject.SetActive(true);
        skinOne.transform.GetChild(1).gameObject.SetActive(false);

        skinTwo.transform.GetChild(0).gameObject.SetActive(true);
        skinTwo.transform.GetChild(1).gameObject.SetActive(false);
        skinTwo.transform.GetChild(2).gameObject.SetActive(true);

        skinThree.transform.GetChild(0).gameObject.SetActive(true);
        skinThree.transform.GetChild(1).gameObject.SetActive(false);
        skinThree.transform.GetChild(2).gameObject.SetActive(true);

        skinFour.transform.GetChild(0).gameObject.SetActive(true);
        skinFour.transform.GetChild(1).gameObject.SetActive(false);
        skinFour.transform.GetChild(2).gameObject.SetActive(true);

        skinFive.transform.GetChild(0).gameObject.SetActive(true);
        skinFive.transform.GetChild(1).gameObject.SetActive(false);
        skinFive.transform.GetChild(2).gameObject.SetActive(true);

        skinSix.transform.GetChild(0).gameObject.SetActive(true);
        skinSix.transform.GetChild(1).gameObject.SetActive(false);
        skinSix.transform.GetChild(2).gameObject.SetActive(true);

        skinSeven.transform.GetChild(0).gameObject.SetActive(true);
        skinSeven.transform.GetChild(1).gameObject.SetActive(false);
        skinSeven.transform.GetChild(2).gameObject.SetActive(true);

        skinEight.transform.GetChild(0).gameObject.SetActive(true);
        skinEight.transform.GetChild(1).gameObject.SetActive(false);
        skinEight.transform.GetChild(2).gameObject.SetActive(true);

        skinNine.transform.GetChild(0).gameObject.SetActive(true);
        skinNine.transform.GetChild(1).gameObject.SetActive(false);
        skinNine.transform.GetChild(2).gameObject.SetActive(true);
    }

    private void Start()
    {
        if(PlayerPrefs.GetInt("level", 1) >= 1)
        {
            skinOne.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 4)
        {
            skinTwo.transform.GetChild(0).gameObject.SetActive(false);
            skinTwo.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 7)
        {
            skinThree.transform.GetChild(0).gameObject.SetActive(false);
            skinThree.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 10)
        {
            skinFour.transform.GetChild(0).gameObject.SetActive(false);
            skinFour.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 13)
        {
            skinFive.transform.GetChild(0).gameObject.SetActive(false);
            skinFive.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 16)
        {
            skinSix.transform.GetChild(0).gameObject.SetActive(false);
            skinSix.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level", 1) >= 21)
        {
            skinSeven.transform.GetChild(0).gameObject.SetActive(false);
            skinSeven.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("TotalStars", 0) >= 45)
        {
            skinEight.transform.GetChild(0).gameObject.SetActive(false);
            skinEight.transform.GetChild(2).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("TotalStars", 0) == 60)
        {
            skinNine.transform.GetChild(0).gameObject.SetActive(false);
            skinNine.transform.GetChild(2).gameObject.SetActive(false);
        }
 

        if (PlayerPrefs.GetInt("Skin", 1) == 1)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 2)
        {
            skinTwo.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 3)
        {
            skinThree.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 4)
        {
            skinFour.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 5)
        {
            skinFive.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 6)
        {
            skinSix.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 7)
        {
            skinSeven.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 8)
        {
            skinEight.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 9)
        {
            skinNine.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void Skin1()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 1)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(true);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 1);
        }
        
    }
    public void Skin2()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 4)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(true);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 2);
        }
        
    }
    public void Skin3()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 7)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(true);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 3);
        }

    }
    public void Skin4()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 10)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(true);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 4);
        }

    }
    public void Skin5()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 13)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(true);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 5);
        }

    }
    public void Skin6()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 16)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(true);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 6);
        }

    }
    public void Skin7()
    {
        if (PlayerPrefs.GetInt("level", 1) >= 21)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(true);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 7);
        }

    }
    public void Skin8()
    {
        if (PlayerPrefs.GetInt("TotalStars", 0) >= 45)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(true);
            skinNine.transform.GetChild(1).gameObject.SetActive(false);

            PlayerPrefs.SetInt("Skin", 8);
        }

    }
    public void Skin9()
    {
        if (PlayerPrefs.GetInt("TotalStars", 0) == 60)
        {
            skinOne.transform.GetChild(1).gameObject.SetActive(false);
            skinTwo.transform.GetChild(1).gameObject.SetActive(false);
            skinThree.transform.GetChild(1).gameObject.SetActive(false);
            skinFour.transform.GetChild(1).gameObject.SetActive(false);
            skinFive.transform.GetChild(1).gameObject.SetActive(false);
            skinSix.transform.GetChild(1).gameObject.SetActive(false);
            skinSeven.transform.GetChild(1).gameObject.SetActive(false);
            skinEight.transform.GetChild(1).gameObject.SetActive(false);
            skinNine.transform.GetChild(1).gameObject.SetActive(true);

            PlayerPrefs.SetInt("Skin", 9);
        }

    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
