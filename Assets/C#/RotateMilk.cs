using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMilk : MonoBehaviour
{
    public GameObject player;
    public AudioSource audioSource;
    public AudioClip hitSound;
    private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 25));
        rotateSpeed = Random.Range(100, 200);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0), Space.World);
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 1.0f)
        {
            ScoreCounter.score += 10;
            audioSource.PlayOneShot(hitSound);
            Destroy(gameObject);
        }
    }
}
