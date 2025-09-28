using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingMultiplayerManager : MonoBehaviour
{

    public Text loadingText;


    void Awake()
    {

        loadingText = GameObject.Find("connectingText").GetComponent<Text>();

        StartCoroutine(LoadingText());
    }

    IEnumerator LoadingText()
    {
        while (true)
        {
            loadingText.text = "Connecting";
            yield return new WaitForSeconds(0.4f);

            loadingText.text = "Connecting.";
            yield return new WaitForSeconds(0.4f);

            loadingText.text = "Connecting..";
            yield return new WaitForSeconds(0.4f);

            loadingText.text = "Connecting...";
            yield return new WaitForSeconds(0.4f);
        }
        

    }

}
