using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    private Transform player;
    private Vector3 TempPos;

    private bool antiGrav = false;

    public delegate void GroundTouch();
    public static event GroundTouch onGroundTouch;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        TempPos = player.position;
        if (antiGrav)
        {
            TempPos.y += 0.0787f;

        } else
        {
            TempPos.y -= 0.0787f;
        }
        
        transform.position = TempPos;
    }

    private void OnEnable()
    {
        Player.antiGravSwitch += switchGrav;
    }

    private void OnDisable()
    {
        Player.antiGravSwitch -= switchGrav;
    }

    private void switchGrav()
    {
        if (antiGrav)
        {
            antiGrav = false;

        } else
        {
            antiGrav = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            if (onGroundTouch != null)
                onGroundTouch();
        }
    }
}
