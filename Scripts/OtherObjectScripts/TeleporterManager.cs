using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class TeleporterManager : MonoBehaviour
{

    public static bool check;

    private int uses;


    public ParticleSystem TeleporterTrail;

    public AudioSource audioSource;
    public AudioClip teleportClip;


    public GameObject player;
    public GameObject destination;
    public GameObject effectPre;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    private void Update()
    {
        Trail();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && check == false)
        {
            check = true;

            uses = PlayerPrefs.GetInt("TimesTeleported");

            uses++;

            PlayerPrefs.SetInt("TimesTeleported", uses);

            player.transform.position = destination.transform.position;
            Instantiate(effectPre, player.transform.position, Quaternion.identity);
            audioSource.PlayOneShot(teleportClip);
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        check = false;
    }

    private void Trail()
    {
        TeleporterTrail.Play();
    }
    
}
