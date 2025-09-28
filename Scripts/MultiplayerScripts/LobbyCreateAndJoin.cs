using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class LobbyCreateAndJoin : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public GameObject waitingText;

    private int randInt;


    private void Awake()
    {
        waitingText.SetActive(false);
    }

    public void CreateRoom()
    {
        if (createInput.text == "" || createInput.text == " ")
        {
            StartCoroutine(Failed()); 
        }
        else
        {
            PhotonNetwork.CreateRoom(createInput.text);
        }
        
    }

    public void JoinRoom()
    {
        if (joinInput.text == "" || joinInput.text == " ")
        {
            StartCoroutine(Failed()); 
        }
        else
        {
            PhotonNetwork.JoinRoom(joinInput.text);
        }
    }

    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        if (PlayerPrefs.GetString("MultiplayerMode") == "Tag")
        {

            if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
            {
                PhotonNetwork.CurrentRoom.IsOpen = false;

                StartCoroutine(Countdown());

            }
            else
            {
                PhotonNetwork.CurrentRoom.IsOpen = true;
            }

        }
        if (PlayerPrefs.GetString("MultiplayerMode") == "Racing")
        {

            if (PhotonNetwork.CurrentRoom.PlayerCount == 2 || PhotonNetwork.CurrentRoom.PlayerCount == 3)
            {

                StartCoroutine(Countdown());

            }
            else if (PhotonNetwork.CurrentRoom.PlayerCount == 4) 
            {
                PhotonNetwork.CurrentRoom.IsOpen = false;
                StartCoroutine(Countdown());
            }
            else
            {
                PhotonNetwork.CurrentRoom.IsOpen = true;
            }

        }

    }

    public override void OnJoinedRoom()
    {
        waitingText.SetActive(true);

        if (PlayerPrefs.GetString("MultiplayerMode") == "Tag")
        {

            if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
            {
                PhotonNetwork.CurrentRoom.IsOpen = false;

                StartCoroutine(Countdown());

            }
            else
            {
                PhotonNetwork.CurrentRoom.IsOpen = true;
            }

        }
        if (PlayerPrefs.GetString("MultiplayerMode") == "Racing")
        {

            if (PhotonNetwork.CurrentRoom.PlayerCount == 2 || PhotonNetwork.CurrentRoom.PlayerCount == 3)
            {

                StartCoroutine(Countdown());

            }
            else if (PhotonNetwork.CurrentRoom.PlayerCount == 4)
            {
                PhotonNetwork.CurrentRoom.IsOpen = false;
                StartCoroutine(Countdown());
            }
            else
            {
                PhotonNetwork.CurrentRoom.IsOpen = true;
            }

        }
    }


    IEnumerator Countdown()
    {
        waitingText.GetComponent<Text>().text = "Starting  in  5";  
        yield return new WaitForSeconds(1f);

        waitingText.GetComponent<Text>().text = "Starting  in  4";
        yield return new WaitForSeconds(1f);

        waitingText.GetComponent<Text>().text = "Starting  in  3";
        yield return new WaitForSeconds(1f);

        waitingText.GetComponent<Text>().text = "Starting  in  2";
        yield return new WaitForSeconds(1f);

        waitingText.GetComponent<Text>().text = "Starting  in  1";
        yield return new WaitForSeconds(1f);

        waitingText.GetComponent<Text>().text = "Starting  in  0";
        StartGame();
    }

    IEnumerator Failed()
    {
        waitingText.SetActive(true);
        waitingText.GetComponent<Text>().text = "Room name cannot be blank.";
        yield return new WaitForSeconds(1f);
        waitingText.GetComponent<Text>().text = "Waiting for players...";
        waitingText.SetActive(false);
    }


    private void StartGame()
    {
        if (PlayerPrefs.GetString("MultiplayerMode") == "Tag")
        {

            randInt = Random.Range(1, 1);

            if (randInt == 1)
            {
                PhotonNetwork.LoadLevel("TagRoom1");
            }
            else if (randInt == 2)
            {
                PhotonNetwork.LoadLevel("TagRoom2");
            }
            else if (randInt == 3)
            {
                PhotonNetwork.LoadLevel("TagRoom3");
            }
            else if (randInt == 4)
            {
                PhotonNetwork.LoadLevel("TagRoom4");
            }
        }
    }

}
