using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LockManager;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip starCollect;
    public AudioClip playerDeath;
    public AudioClip keyCollect;
    public AudioClip doorBreak;


    private void OnEnable()
    {
        Player.onPlayerDeath += playerIsDead;
        StarManager.onStarCollect += starCollected;
        Player.onKeyCollect += foundKey;
        LockManager.onKeyUse += usedKey;

    }

    private void OnDisable()
    {
        Player.onPlayerDeath -= playerIsDead;
        StarManager.onStarCollect -= starCollected;
        Player.onKeyCollect -= foundKey;
        LockManager.onKeyUse -= usedKey;

    }


    private void playerIsDead()
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            audioSource.PlayOneShot(playerDeath);
        }
        
    }

    private void starCollected()
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            audioSource.PlayOneShot(starCollect);
        }
        
    }

    private void foundKey()
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            audioSource.PlayOneShot(keyCollect);
        }

    }

    private void usedKey()
    {
        if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            audioSource.PlayOneShot(doorBreak);
        }

    }

}
