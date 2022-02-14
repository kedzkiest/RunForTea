using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityStandardAssets.Characters.ThirdPerson;

public class Initial : MonoBehaviour
{
    public GameObject player;

    public Canvas startCanvas;
    public Canvas playCanvas;

    public Avatar idle;
    public Avatar onPlaying;

    public static bool firstSpacePress;
    
    // Start is called before the first frame update
    void Start()
    {
        firstSpacePress = true;
        
        startCanvas.enabled = true;
        playCanvas.enabled = false;
        player.GetComponent<ThirdPersonUserControl>().enabled = false;
        player.GetComponent<Animator>().avatar = idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && firstSpacePress)
        {
            firstSpacePress = false;
            
            startCanvas.enabled = false;
            playCanvas.enabled = true;
            player.GetComponent<ThirdPersonUserControl>().enabled = true;
            player.GetComponent<Animator>().avatar = onPlaying;

            TimeCounter.countdown = 60.0f;
        }
    }
}
