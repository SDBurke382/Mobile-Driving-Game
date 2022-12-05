using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    
    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        if (gameOver)
        {
            Debug.Log("You caught the theif");
            gameOver = true;
        }
        
    }

    public void Lose()
    {
        if (!gameOver)
        {
            Debug.Log("He got away");
            gameOver = true;
        }
       
    }
}
