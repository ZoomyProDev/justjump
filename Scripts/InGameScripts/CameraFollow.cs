using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float minX, maxX, minY, maxY;

    private Transform player;
    private Vector3 tempPos;

    public Camera Camera;


    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }



    private void LateUpdate()
    {


        if (player == null)
            return;


        tempPos = transform.position;
        tempPos.x = player.position.x;
        tempPos.y = player.position.y;

        if (tempPos.x <= minX)
            tempPos.x = minX;
        if (tempPos.x >= maxX)
            tempPos.x = maxX;
        if (tempPos.y <= minY)
            tempPos.y = minY;
        if (tempPos.y >= maxY)
            tempPos.y = maxY;

        transform.position = tempPos;
        

        

    }





}
