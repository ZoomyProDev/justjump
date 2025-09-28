using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravEffect : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip hitClip;

    private Transform player;

    public ParticleSystem antiGravEffect;

    private void OnEnable()
    {
        Player.antiGravSwitch += switchGrav;
    }

    private void OnDisable()
    {
        Player.antiGravSwitch -= switchGrav;
    }

    void switchGrav()
    {
        player = GameObject.FindWithTag("Player").transform;
        if (PlayerPrefs.GetInt("SFX", 1) == 1)
        {
            audioSource.PlayOneShot(hitClip);
        }
        transform.position = player.position;
        antiGravEffect.Play();

    }

}
