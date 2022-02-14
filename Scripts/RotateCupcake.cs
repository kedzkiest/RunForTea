using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCupcake : MonoBehaviour
{
    public GameObject player;
    public AudioSource audioSource;
    public AudioClip hitSound;
    private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(Random.Range(-20, 20), 0, 0);
        rotateSpeed = Random.Range(150, 300);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0), Space.World);
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1.0f)
        {
            ScoreCounter.score += 100;
            audioSource.PlayOneShot(hitSound);
            Destroy(gameObject);
        }
    }
}
