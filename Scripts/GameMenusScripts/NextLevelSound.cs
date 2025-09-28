using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelSound : MonoBehaviour
{

    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("MUSIC", 1) == 1)
        {
            music.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
