using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BestTimesManager : MonoBehaviour
{

    public Text AnyStarsLevel1;
    public Text AnyStarsLevel2;
    public Text AnyStarsLevel3;
    public Text AnyStarsLevel4;
    public Text AnyStarsLevel5;
    public Text AnyStarsLevel6;
    public Text AnyStarsLevel7;
    public Text AnyStarsLevel8;
    public Text AnyStarsLevel9;
    public Text AnyStarsLevel10;
    public Text AnyStarsLevel11;
    public Text AnyStarsLevel12;
    public Text AnyStarsLevel13;
    public Text AnyStarsLevel14;
    public Text AnyStarsLevel15;
    public Text AnyStarsLevel16;
    public Text AnyStarsLevel17;
    public Text AnyStarsLevel18;
    public Text AnyStarsLevel19;
    public Text AnyStarsLevel20;
    public Text AllStarsLevel1;
    public Text AllStarsLevel2;
    public Text AllStarsLevel3;
    public Text AllStarsLevel4;
    public Text AllStarsLevel5;
    public Text AllStarsLevel6;
    public Text AllStarsLevel7;
    public Text AllStarsLevel8;
    public Text AllStarsLevel9;
    public Text AllStarsLevel10;
    public Text AllStarsLevel11;
    public Text AllStarsLevel12;
    public Text AllStarsLevel13;
    public Text AllStarsLevel14;
    public Text AllStarsLevel15;
    public Text AllStarsLevel16;
    public Text AllStarsLevel17;
    public Text AllStarsLevel18;
    public Text AllStarsLevel19;
    public Text AllStarsLevel20;
    public Text AnyStarsAllLevels;
    public Text AllStarsAllLevels;



    public void Back()
    {
        SceneManager.LoadScene("Extras");
    }

    
    public void Start()
    {
        if (PlayerPrefs.GetFloat("AnyStarsLevel1", 0) == 0)
        {
            AnyStarsLevel1.text = " Level  1:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel1"));
            AnyStarsLevel1.text = " Level  1:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel2", 0) == 0)
        {
            AnyStarsLevel2.text = " Level  2:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel2"));
            AnyStarsLevel2.text = " Level  2:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel3", 0) == 0)
        {
            AnyStarsLevel3.text = " Level  3:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel3"));
            AnyStarsLevel3.text = " Level  3:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel4", 0) == 0)
        {
            AnyStarsLevel4.text = " Level  4:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel4"));
            AnyStarsLevel4.text = " Level  4:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel5", 0) == 0)
        {
            AnyStarsLevel5.text = " Level  5:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel5"));
            AnyStarsLevel5.text = " Level  5:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel6", 0) == 0)
        {
            AnyStarsLevel6.text = " Level  6:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel6"));
            AnyStarsLevel6.text = " Level  6:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel7", 0) == 0)
        {
            AnyStarsLevel7.text = " Level  7:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel7"));
            AnyStarsLevel7.text = " Level  7:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel8", 0) == 0)
        {
            AnyStarsLevel8.text = " Level  8:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel8"));
            AnyStarsLevel8.text = " Level  8:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel9", 0) == 0)
        {
            AnyStarsLevel9.text = " Level  9:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel9"));
            AnyStarsLevel9.text = " Level  9:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel10", 0) == 0)
        {
            AnyStarsLevel10.text = " Level  10:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel10"));
            AnyStarsLevel10.text = " Level  10:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel11", 0) == 0)
        {
            AnyStarsLevel11.text = " Level  11:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel11"));
            AnyStarsLevel11.text = " Level  11:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel12", 0) == 0)
        {
            AnyStarsLevel12.text = " Level  12:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel12"));
            AnyStarsLevel12.text = " Level  12:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel13", 0) == 0)
        {
            AnyStarsLevel13.text = " Level  13:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel13"));
            AnyStarsLevel13.text = " Level  13:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel14", 0) == 0)
        {
            AnyStarsLevel14.text = " Level  14:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel14"));
            AnyStarsLevel14.text = " Level  14:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel15", 0) == 0)
        {
            AnyStarsLevel15.text = " Level  15:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel15"));
            AnyStarsLevel15.text = " Level  15:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel16", 0) == 0)
        {
            AnyStarsLevel16.text = " Level  16:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel16"));
            AnyStarsLevel16.text = " Level  16:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel17", 0) == 0)
        {
            AnyStarsLevel17.text = " Level  17:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel17"));
            AnyStarsLevel17.text = " Level  17:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel18", 0) == 0)
        {
            AnyStarsLevel18.text = " Level  18:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel18"));
            AnyStarsLevel18.text = " Level  18:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel19", 0) == 0)
        {
            AnyStarsLevel19.text = " Level  19:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel19"));
            AnyStarsLevel19.text = " Level  19:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsLevel20", 0) == 0)
        {
            AnyStarsLevel20.text = " Level  20:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsLevel20"));
            AnyStarsLevel20.text = " Level  20:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel1", 0) == 0)
        {
            AllStarsLevel1.text = " Level  1:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel1"));
            AllStarsLevel1.text = " Level  1:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel2", 0) == 0)
        {
            AllStarsLevel2.text = " Level  2:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel2"));
            AllStarsLevel2.text = " Level  2:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel3", 0) == 0)
        {
            AllStarsLevel3.text = " Level  3:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel3"));
            AllStarsLevel3.text = " Level  3:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel4", 0) == 0)
        {
            AllStarsLevel4.text = " Level  4:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel4"));
            AllStarsLevel4.text = " Level  4:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel5", 0) == 0)
        {
            AllStarsLevel5.text = " Level  5:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel5"));
            AllStarsLevel5.text = " Level  5:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel6", 0) == 0)
        {
            AllStarsLevel6.text = " Level  6:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel6"));
            AllStarsLevel6.text = " Level  6:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel7", 0) == 0)
        {
            AllStarsLevel7.text = " Level  7:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel7"));
            AllStarsLevel7.text = " Level  7:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel8", 0) == 0)
        {
            AllStarsLevel8.text = " Level  8:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel8"));
            AllStarsLevel8.text = " Level  8:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel9", 0) == 0)
        {
            AllStarsLevel9.text = " Level  9:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel9"));
            AllStarsLevel9.text = " Level  9:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel10", 0) == 0)
        {
            AllStarsLevel10.text = " Level  10:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel10"));
            AllStarsLevel10.text = " Level  10:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel11", 0) == 0)
        {
            AllStarsLevel11.text = " Level  11:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel11"));
            AllStarsLevel11.text = " Level  11:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel12", 0) == 0)
        {
            AllStarsLevel12.text = " Level  12:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel12"));
            AllStarsLevel12.text = " Level  12:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel13", 0) == 0)
        {
            AllStarsLevel13.text = " Level  13:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel13"));
            AllStarsLevel13.text = " Level  13:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel14", 0) == 0)
        {
            AllStarsLevel14.text = " Level  14:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel14"));
            AllStarsLevel14.text = " Level  14:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel15", 0) == 0)
        {
            AllStarsLevel15.text = " Level  15:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel15"));
            AllStarsLevel15.text = " Level  15:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel16", 0) == 0)
        {
            AllStarsLevel16.text = " Level  16:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel16"));
            AllStarsLevel16.text = " Level  16:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel17", 0) == 0)
        {
            AllStarsLevel17.text = " Level  17:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel17"));
            AllStarsLevel17.text = " Level  17:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel18", 0) == 0)
        {
            AllStarsLevel18.text = " Level  18:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel18"));
            AllStarsLevel18.text = " Level  18:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel19", 0) == 0)
        {
            AllStarsLevel19.text = " Level  19:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel19"));
            AnyStarsLevel19.text = " Level  19:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsLevel20", 0) == 0)
        {
            AllStarsLevel20.text = " Level  20:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsLevel20"));
            AllStarsLevel20.text = " Level  20:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AnyStarsAllLevels", 0) == 0)
        {
            AnyStarsAllLevels.text = " A ll  Levels:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AnyStarsAllLevels"));
            AnyStarsAllLevels.text = "  A ll  Levels:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
        if (PlayerPrefs.GetFloat("AllStarsAllLevels", 0) == 0)
        {
            AllStarsAllLevels.text = "  A ll  Levels:  N/A";
        }
        else
        {
            TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("AllStarsAllLevels"));
            AllStarsAllLevels.text = "  A ll  Levels:  " + time.ToString(@"hh\:mm\:ss\.ff");
        }
    }
}
