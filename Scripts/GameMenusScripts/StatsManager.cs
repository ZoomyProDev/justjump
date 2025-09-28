using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatsManager : MonoBehaviour
{

    public Text TotalStars;
    public Text Deaths;
    public Text Jumps;
    public Text EnemiesKilled;
    public Text GravitySwitches;
    public Text DoorsUnlocked;
    public Text TimesTeleported;

    private int TS;
    private int deaths;
    private int jumps;
    private int enKilled;
    private int gravs;
    private int doors;
    private int tele;



    private void Start()
    {
        TS = PlayerPrefs.GetInt("TotalStars");
        deaths = PlayerPrefs.GetInt("Deaths");
        jumps = PlayerPrefs.GetInt("Jumps");
        enKilled = PlayerPrefs.GetInt("EnemiesKilled");
        gravs = PlayerPrefs.GetInt("GravitySwitches");
        doors = PlayerPrefs.GetInt("DoorsUnlocked");
        tele = PlayerPrefs.GetInt("TimesTeleported");

        TotalStars.text = "Total  Stars: " + TS.ToString();
        Deaths.text = "Deaths: " + deaths.ToString();
        Jumps.text = "Jumps: " + jumps.ToString();
        EnemiesKilled.text = "Enemies  Killed: " + enKilled.ToString();
        GravitySwitches.text = "Gravity  Switches: " + gravs.ToString();
        DoorsUnlocked.text = "Doors  Unlocked: " + doors.ToString();
        TimesTeleported.text = "Times  Teleported: " + tele.ToString();

    }



    public void Back()
    {
        SceneManager.LoadScene("Extras");
    }
}
