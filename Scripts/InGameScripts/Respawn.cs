using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    private Scene currentScene;


    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    private void OnEnable()
    {
        Player.playerRespawn += playerRe;
    }

    private void OnDisable()
    {
        Player.playerRespawn -= playerRe;
    }

    private void playerRe()
    {
        StartCoroutine(Show());
        
    }

    IEnumerator Show()
    {
        yield return new WaitForSeconds(2);
        
        SceneManager.LoadScene(currentScene.name);
        

    }


}
