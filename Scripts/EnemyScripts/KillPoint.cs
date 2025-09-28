using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPoint : MonoBehaviour
{
    private Vector3 TempPos;
    public GameObject Enemy;

    public bool dead = false;

    public delegate void EnemyDeath();
    public static event EnemyDeath onEnemyDeath;


    private void Awake()
    {
        
    }


    private void Update()
    {
        TempPos = Enemy.transform.position;
        transform.position = TempPos;

        if (Enemy.GetComponent<Enemy>().antiGravEnemy == true)
        {
             transform.eulerAngles = new Vector3(0f, 0f, 180f);

        } else
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            dead = true;

            if (onEnemyDeath != null)
                onEnemyDeath();

            Destroy(gameObject);

        }
    }
}
