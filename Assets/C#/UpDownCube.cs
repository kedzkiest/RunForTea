using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownCube : MonoBehaviour
{
    private bool up;
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 4)
        {
            up = false;
        }
        else if (transform.position.y <= -2)
        {
            up = true;
        }
        
        if (up)
        {
            transform.position += new Vector3(0, Time.deltaTime * moveSpeed, 0);
        }
        else
        {
            transform.position -= new Vector3(0, Time.deltaTime * moveSpeed, 0);
        }
    }
}
