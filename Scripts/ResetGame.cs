using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public GameObject player;
    public Canvas resetCanvas;
    private bool isDropped;
    // Start is called before the first frame update
    void Start()
    {
        isDropped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= -5)
        {
            isDropped = true;
            resetCanvas.enabled = true;
        }
        else
        {
            isDropped = false;
            resetCanvas.enabled = false;
        }

        if (TimeCounter.isTimeUp)
        {
            isDropped = false;
            resetCanvas.enabled = false;
        }
        
        if (Input.GetKey(KeyCode.R) && isDropped)
        {
            player.transform.position = new Vector3(0, 1, 0);
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
