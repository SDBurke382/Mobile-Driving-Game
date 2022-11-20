using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public WinLose winLoseScript;
    public GameObject player;
    public GameObject enemy;
   


    // Start is called before the first frame update
    void Start()
    {
        
        winLoseScript.GetComponent<WinLose>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider enemy)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            Destroy(enemy);
            winLoseScript.Win();
        }

        else 
        {
            winLoseScript.Lose();
        }

    }
}
