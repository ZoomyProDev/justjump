using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.VisualScripting;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public GameObject cameraPrefab;
    public GameObject menuPrefab;

    private void Start()
    {
        var newPlayer = PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(7.98f, -0.285f, 0f), Quaternion.identity);
        var newCam = PhotonNetwork.Instantiate(cameraPrefab.name, Vector3.zero, Quaternion.identity);
        var newMenu = PhotonNetwork.Instantiate(menuPrefab.name, Vector3.zero, Quaternion.identity);

        newCam.GetComponent<MultiplayerCameraFollow>().player = newPlayer.transform;
        newCam.transform.position = new Vector3(transform.position.x, transform.position.y, -1); 
        newMenu.GetComponent<MultiplayerInGameMenu>().player = newPlayer.transform;
        newMenu.GetComponent<MultiplayerInGameMenu>().Camera = newCam.GetComponent<Camera>();



    }

    
}
