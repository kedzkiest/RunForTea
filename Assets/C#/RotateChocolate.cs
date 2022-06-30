using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChocolate : MonoBehaviour
{
    public GameObject player;
    public AudioSource audioSource;
    public AudioClip hitSound;
    private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(Random.Range(-45, -30), 90, 0);
        rotateSpeed = Random.Range(150, 400);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0), Space.World);
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1.0f)
        {
            ScoreCounter.score += 30;
            audioSource.PlayOneShot(hitSound);
            Destroy(gameObject);
        }
    }
}
