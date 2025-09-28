using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;

    public GameObject playerPre;
    public GameObject explodePlayerPre;
    public ParticleSystem antiGravPre;
    public GameObject respawnPre;
    public GameObject basePre;
    


    [SerializeField]
    private Vector3 playerStartPos, respawnStartPos;

    private void Awake()
    {

        Screen.fullScreen = !Screen.fullScreen;

        PlayerPrefs.SetInt("Speedrun", 0);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += nextLevel;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= nextLevel;
    }




    private void nextLevel(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainMenu")
        {




        }

        if (scene.name == "Level1")
        {
            if (PlayerPrefs.GetInt("level", 1) <= 1)
            {
                PlayerPrefs.SetInt("level", 1);
            }
            

            playerStartPos = new Vector3(-1.353f, 0.45f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level2")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 2)
            {
                PlayerPrefs.SetInt("level", 2);
            }

            playerStartPos = new Vector3(-3.271f, 1.372f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level3")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 3)
            {
                PlayerPrefs.SetInt("level", 3);
            }

            playerStartPos = new Vector3(-3.492f, -0.632f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level4")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 4)
            {
                PlayerPrefs.SetInt("level", 4);
            }

            playerStartPos = new Vector3(0f, -2.241f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level5")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 5)
            {
                PlayerPrefs.SetInt("level", 5);
            }

            playerStartPos = new Vector3(-3.39f, -1.92f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level6")
        {
            if (PlayerPrefs.GetInt("level", 1) <= 6)
            {
                PlayerPrefs.SetInt("level", 6);
            }


            playerStartPos = new Vector3(-3.471f, -1.974f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);



        }
        if (scene.name == "Level7")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 7)
            {
                PlayerPrefs.SetInt("level", 7);
            }

            playerStartPos = new Vector3(-3.634f, -3.052f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level8")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 8)
            {
                PlayerPrefs.SetInt("level", 8);
            }

            playerStartPos = new Vector3(-3.47f, -2.781f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level9")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 9)
            {
                PlayerPrefs.SetInt("level", 9);
            }

            playerStartPos = new Vector3(-3.629f, -2.655f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level10")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 10)
            {
                PlayerPrefs.SetInt("level", 10);
            }

            playerStartPos = new Vector3(-4.7213f, -3.4844f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level11")
        {
            if (PlayerPrefs.GetInt("level", 1) <= 11)
            {
                PlayerPrefs.SetInt("level", 11);
            }


            playerStartPos = new Vector3(-5.111f, -2.609f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);



        }
        if (scene.name == "Level12")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 12)
            {
                PlayerPrefs.SetInt("level", 12);
            }

            playerStartPos = new Vector3(-5.123f, 2.414f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level13")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 13)
            {
                PlayerPrefs.SetInt("level", 13);
            }

            playerStartPos = new Vector3(-3.203f, -3.764f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level14")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 14)
            {
                PlayerPrefs.SetInt("level", 14);
            }

            playerStartPos = new Vector3(-4.893f, -3.251f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level15")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 15)
            {
                PlayerPrefs.SetInt("level", 15);
            }

            playerStartPos = new Vector3(-9.508f, -2.31f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level16")
        {
            if (PlayerPrefs.GetInt("level", 1) <= 16)
            {
                PlayerPrefs.SetInt("level", 16);
            }


            playerStartPos = new Vector3(-4.774f, -3.352f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level17")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 17)
            {
                PlayerPrefs.SetInt("level", 17);
            }

            playerStartPos = new Vector3(-4.525f, -3.621f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);
        }

        if (scene.name == "Level18")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 18)
            {
                PlayerPrefs.SetInt("level", 18);
            }

            playerStartPos = new Vector3(-5.083f, -3.573f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level19")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 19)
            {
                PlayerPrefs.SetInt("level", 19);
            }

            playerStartPos = new Vector3(-15.396f, -4.567f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);

            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

        if (scene.name == "Level20")
        {

            if (PlayerPrefs.GetInt("level", 1) <= 20)
            {
                PlayerPrefs.SetInt("level", 20);
            }

            playerStartPos = new Vector3(2.936f, -1.117f, 0f);
            Instantiate(playerPre, playerStartPos, Quaternion.identity);
            Instantiate(basePre, playerStartPos, Quaternion.identity);

            Instantiate(respawnPre, respawnStartPos, Quaternion.identity);


            Instantiate(explodePlayerPre, playerStartPos, Quaternion.identity);

            Instantiate(antiGravPre, playerStartPos, Quaternion.identity);

        }

    }
}
        