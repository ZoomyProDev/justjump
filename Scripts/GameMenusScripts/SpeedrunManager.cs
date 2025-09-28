using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SpeedrunManager : MonoBehaviour
{
    public Text titleText;
    public Text mainText;

    private String stringTime;

    private Scene scene;

    public void Back()
    {
        SceneManager.LoadScene("Extras");
    }

    public void Back2()
    {
        SceneManager.LoadScene("Speedrun1");
    }

    public void Retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastSceneNum"));
    }

    public void AllLevels()
    {
        SceneManager.LoadScene("Speedrun2");
        PlayerPrefs.SetInt("AllLevels", 1);
        PlayerPrefs.SetInt("SingleLevel", 0);
        PlayerPrefs.SetFloat("SavedTime", 0);
    }

    public void SingleLevel()
    {
        SceneManager.LoadScene("Speedrun2");
        PlayerPrefs.SetInt("SingleLevel", 1);
        PlayerPrefs.SetInt("AllLevels", 0);
    }

    public void AllStars()
    {

        PlayerPrefs.SetInt("AllStars", 1);
        PlayerPrefs.SetInt("NoStars", 0);


        if (PlayerPrefs.GetInt("AllLevels") == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        else if (PlayerPrefs.GetInt("SingleLevel") == 1)
        {
            SceneManager.LoadScene("LevelSelect");
        }
 
    }

    public void NoStars()
    {

        PlayerPrefs.SetInt("NoStars", 1);
        PlayerPrefs.SetInt("AllStars", 0);


        if (PlayerPrefs.GetInt("AllLevels") == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        else if (PlayerPrefs.GetInt("SingleLevel") == 1)
        {
            SceneManager.LoadScene("LevelSelect");
        }

    }

    public void Leaderboards()
    {
        if (PlayerPrefs.GetInt("AllStars", 0) == 1)
        {
            if (PlayerPrefs.GetInt("AllLevels", 0) == 1)
            {
                //playFabManager.GetLeaderboard("AllLevelsAllStars");
            }
            else if (PlayerPrefs.GetInt("SingleLevel", 0) == 1)
            {
                //playFabManager.GetLeaderboard("Level" + PlayerPrefs.GetInt("lastSceneNum").ToString() + "AllStars");
            }
            
        }
        else if (PlayerPrefs.GetInt("NoStars", 0) == 1)
        {
            if (PlayerPrefs.GetInt("AllLevels", 0) == 1)
            {
                //playFabManager.GetLeaderboard("AllLevelsNoStars");
            }
            else if (PlayerPrefs.GetInt("SingleLevel", 0) == 1)
            {
                //playFabManager.GetLeaderboard("Level" + PlayerPrefs.GetInt("lastSceneNum").ToString() + "NoStars");
            }
        }
        
    }

    public void Start()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "SpeedrunFinished")
        {
            if (PlayerPrefs.GetInt("AllLevels", 0) == 1)
            {
                titleText.text = "All  Levels  ";

            }
            else if (PlayerPrefs.GetInt("SingleLevel", 0) == 1)
            {
                titleText.text = "Level  " + PlayerPrefs.GetInt("lastSceneNum").ToString() + "  ";
            }
            if (PlayerPrefs.GetInt("AllStars", 0) == 1)
            {
                titleText.text = titleText.text + "All  Stars  Speedrun  Finished";
            }
            else if (PlayerPrefs.GetInt("NoStars", 0) == 1)
            {
                titleText.text = titleText.text + "Any  Stars  Speedrun  Finished";
            }

            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("FinalTime"));
            mainText.text = "The  Run  Was  Completed  In  " + time.ToString(@"hh\:mm\:ss\.ff");



            if (PlayerPrefs.GetInt("AllLevels", 0) == 1)
            {
                if (PlayerPrefs.GetInt("AllStars", 0) == 1)
                {
                    if (PlayerPrefs.GetFloat("AllStarsAllLevels", 0) == 0)
                    {
                        PlayerPrefs.SetFloat("AllStarsAllLevels", PlayerPrefs.GetFloat("FinalTime"));
                    }
                    else if (PlayerPrefs.GetFloat("FinalTime") < PlayerPrefs.GetFloat("AllStarsAllLevels"))
                    {
                        PlayerPrefs.SetFloat("AllStarsAllLevels", PlayerPrefs.GetFloat("FinalTime"));
                    }

                    TimeSpan time2 = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsAllLevels"));
                    mainText.text = mainText.text + "\n\n" + "Best  time  on  this  run  is  " + time2.ToString(@"hh\:mm\:ss\.ff");

                }
                else if (PlayerPrefs.GetInt("NoStars", 0) == 1)
                {
                    if (PlayerPrefs.GetFloat("AnyStarsAllLevels", 0) == 0)
                    {
                        PlayerPrefs.SetFloat("AnyStarsAllLevels", PlayerPrefs.GetFloat("FinalTime"));
                    }
                    else if (PlayerPrefs.GetFloat("FinalTime") < PlayerPrefs.GetFloat("AnyStarsAllLevels"))
                    {
                        PlayerPrefs.SetFloat("AnyStarsAllLevels", PlayerPrefs.GetFloat("FinalTime"));
                    }

                    TimeSpan time2 = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsAllLevels"));
                    mainText.text = mainText.text + "\n\n" + "Best  time  on  this  run  is  " + time2.ToString(@"hh\:mm\:ss\.ff");

                }

            }
            else if (PlayerPrefs.GetInt("SingleLevel", 0) == 1)
            {
                if (PlayerPrefs.GetInt("AllStars", 0) == 1)
                {
                    if (PlayerPrefs.GetFloat("AllStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), 0) == 0)
                    {
                        PlayerPrefs.SetFloat("AllStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), PlayerPrefs.GetFloat("FinalTime"));
                    }
                    else if (PlayerPrefs.GetFloat("FinalTime") < PlayerPrefs.GetFloat("AllStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString()))
                    {
                        PlayerPrefs.SetFloat("AllStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), PlayerPrefs.GetFloat("FinalTime"));
                    }

                    TimeSpan time2 = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), 0));
                    mainText.text = mainText.text + "\n\n" + "Best  time  on  this  run  is  " + time2.ToString(@"hh\:mm\:ss\.ff");

                }
                else if (PlayerPrefs.GetInt("NoStars", 0) == 1)
                {
                    if (PlayerPrefs.GetFloat("AnyStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), 0) == 0)
                    {
                        PlayerPrefs.SetFloat("AnyStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), PlayerPrefs.GetFloat("FinalTime"));
                    }
                    else if (PlayerPrefs.GetFloat("FinalTime") < PlayerPrefs.GetFloat("AnyStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString()))
                    {
                        PlayerPrefs.SetFloat("AnyStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), PlayerPrefs.GetFloat("FinalTime"));
                    }

                    TimeSpan time2 = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel" + PlayerPrefs.GetInt("lastSceneNum").ToString(), 0));
                    mainText.text = mainText.text + "\n\n" + "Best  time  on  this  run  is  " + time2.ToString(@"hh\:mm\:ss\.ff");

                }
            }
           
            
        }
    }
}
