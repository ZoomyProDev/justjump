using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MultiplayerCameraFollow : MonoBehaviour
{
    public float minX, maxX, minY, maxY;

    public Transform player;
    private Vector3 tempPos;

    public Camera Camera;

    PhotonView view;

    public void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public void LateUpdate()
    {
        if (view.IsMine)
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
}
