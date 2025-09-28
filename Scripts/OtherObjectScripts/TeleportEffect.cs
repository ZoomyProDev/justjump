using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEffect : MonoBehaviour
{

    public ParticleSystem teleportEffect;



    private void Start()
    {
        StartCoroutine(Effect());
    }

    IEnumerator Effect()
    {

        teleportEffect.Play();

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }


}
