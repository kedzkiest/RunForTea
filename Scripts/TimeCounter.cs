using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public GameObject player;
    public static float countdown;

    public Canvas timeupCanvas;

    public Text timeText;

    public static bool isTimeUp;
    
    // Start is called before the first frame update
    void Start()
    {
        isTimeUp = false;
        timeupCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Initial.firstSpacePress)
        {
            countdown -= Time.deltaTime;
            timeText.text = countdown.ToString("f1") + "s";

            if (countdown <= 0)
            {
                isTimeUp = true;
                
                timeText.text = "Time's up!";
                player.GetComponent<ThirdPersonUserControl>().enabled = false;
                player.GetComponent<Animator>().enabled = false;
                player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                Invoke("TimeupCanvasPopUp", 2.0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.T) && isTimeUp)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void TimeupCanvasPopUp()
    {
        timeupCanvas.enabled = true;
    }
}
