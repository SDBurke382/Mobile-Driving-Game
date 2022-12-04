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
    public float smooth = 0.4f;
    
    public float newRotation;
    public float sensitivity = 6;
    private Vector3 currentAcceleration, initialAcceleration;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        source.Play();
        initialAcceleration = Input.acceleration;
        currentAcceleration = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");        
        //Moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Rotates the vehicle based on input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        currentAcceleration = Vector3.Lerp(currentAcceleration, Input.acceleration - initialAcceleration, Time.deltaTime / smooth);

        newRotation = Mathf.Clamp(currentAcceleration.x * sensitivity, -1, 1);
        transform.Rotate(0, 0, -newRotation);



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
