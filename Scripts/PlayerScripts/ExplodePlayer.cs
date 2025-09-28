using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodePlayer : MonoBehaviour
{
    private Transform player;

    public ParticleSystem PlayerExplode1;
    public ParticleSystem PlayerExplode2;
    public ParticleSystem PlayerExplode3;
    public ParticleSystem PlayerExplode4;
    public ParticleSystem PlayerExplode5;
    public ParticleSystem PlayerExplode6;
    public ParticleSystem PlayerExplode7;
    public ParticleSystem PlayerExplode8;
    public ParticleSystem PlayerExplode9;


    [System.Obsolete]
    private void OnEnable()
    {
        Player.onPlayerDeath += playerIsDead;
        Player.antiGravSwitch += switchGrav;
    }

    [System.Obsolete]
    private void OnDisable()
    {
        Player.onPlayerDeath -= playerIsDead;
        Player.antiGravSwitch -= switchGrav;
    }

    void playerIsDead()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            player = GameObject.FindWithTag("Player").transform;
            transform.position = player.position;

            if (PlayerPrefs.GetInt("Skin", 1) == 1)
            {
                PlayerExplode1.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 2)
            {
                PlayerExplode2.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 3)
            {
                PlayerExplode3.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 4)
            {
                PlayerExplode4.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 5)
            {
                PlayerExplode5.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 6)
            {
                PlayerExplode6.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 7)
            {
                PlayerExplode7.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 8)
            {
                PlayerExplode8.Play();
            }
            else if (PlayerPrefs.GetInt("Skin") == 9)
            {
                PlayerExplode9.Play();
            }
        }
        

    }

    [System.Obsolete]
    private void switchGrav()
    {
        PlayerExplode1.gravityModifier *= -1;
        PlayerExplode2.gravityModifier *= -1;
        PlayerExplode3.gravityModifier *= -1;
        PlayerExplode4.gravityModifier *= -1;
        PlayerExplode5.gravityModifier *= -1;
        PlayerExplode6.gravityModifier *= -1;
        PlayerExplode7.gravityModifier *= -1;
        PlayerExplode8.gravityModifier *= -1;
        PlayerExplode9.gravityModifier *= -1;
    }
}
