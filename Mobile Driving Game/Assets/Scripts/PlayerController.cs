using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 12.0f;
    private float horizontalInput;   
    public Rigidbody playerRb;
    private AudioSource source;
    public SpawnManager spawnManager;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");        
        //Moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Rotates the vehicle based on input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        
         


    }

    public void OnTriggerEnter(Collider Obstacle)
    {
        Debug.Log("Slow Down");
        StartCoroutine("SlowDown");
        spawnManager.SpawnTriggerEntered();
    }

    IEnumerator SlowDown()
    {
        speed = 4;
        yield return new WaitForSeconds(3);
        speed = 8;
    }

    


}
