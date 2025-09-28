using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{

    public GameObject menuBox;
    public Camera Camera;
    public Transform player;
    public GameObject menuButton;
    public GameObject Canvas;
    private Vector3 TempPos;
    private Vector3 TempPos2;


    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        menuBox.SetActive(false);

    }

    private void Update()
    {
        transform.position = Camera.transform.position;

        TempPos = new Vector3(0f, 0f, 0f);
        TempPos.x = -857f;
        TempPos.y = 441f;

        TempPos2 = transform.position;
        TempPos2.z = 0f;

        
    }

    private void LateUpdate()
    {
        menuButton.transform.localPosition = TempPos;

        transform.position = TempPos2;

        menuBox.transform.localPosition = new Vector3(0f, 0f, 0f);
    }

    
}
