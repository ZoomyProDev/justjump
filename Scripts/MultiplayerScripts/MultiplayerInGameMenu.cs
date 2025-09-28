using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MultiplayerInGameMenu : MonoBehaviour
{
    public GameObject menuBox;
    public Camera Camera;
    public Transform player;
    public GameObject menuButton;
    public GameObject Canvas;
    private Vector3 TempPos;
    private Vector3 TempPos2;

    PhotonView view;


    public void Start()
    {
        view = GetComponent<PhotonView>();

        if (view.IsMine)
        {
            menuBox.SetActive(false);
        }
        
    }

    private void Update()
    {
        if (view.IsMine)
        {
            transform.position = Camera.transform.position;

            TempPos = new Vector3(0f, 0f, 0f);
            TempPos.x = -857f;
            TempPos.y = 441f;

            TempPos2 = transform.position;
            TempPos2.z = 0f;
        }
        


    }

    private void LateUpdate()
    {
        if (view.IsMine)
        {
            menuButton.transform.localPosition = TempPos;

            transform.position = TempPos2;

            menuBox.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        
    }
}
