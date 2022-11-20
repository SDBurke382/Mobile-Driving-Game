using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour   
{
    public float speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
   
    }

    public void OnTriggerEnter(Collider Player)
    {
        //place win condition here
        Debug.Log("Hit Detected");
    }
}
