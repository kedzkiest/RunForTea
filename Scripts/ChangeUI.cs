using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChangeUI : MonoBehaviour
{
    public Text startText;

    public Text resetPositionText;

    public Text backTitleText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Get Joystick Names
        string[] temp = Input.GetJoystickNames();
 
        //Check whether array contains anything
        if(temp.Length > 0)
        {
            //Iterate over every element
            for(int i =0; i < temp.Length; ++i)
            {
                //Check if the string is empty or not
                if(!string.IsNullOrEmpty(temp[i]))
                {
                    //Not empty, controller temp[i] is connected
                    //Debug.Log("Controller " + i + " is connected using: " + temp[i]);
                    startText.text = "Press A to start";
                    resetPositionText.text = "Press X to reset position";
                    backTitleText.text = "Press B to return to title";
                }
                else
                {
                    //If it is empty, controller i is disconnected
                    //where i indicates the controller number
                    //Debug.Log("Controller: " + i + " is disconnected.");
                    startText.text = "Press space to start";
                    resetPositionText.text = "Press R to reset position";
                    backTitleText.text = "Press T to return to title";
 
                }
            }
        }
    }
}

