using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public Text winText;
    public Text loseText;
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
            gameOver = true;
            winText.text = "You caught the thief";
        }
        
    }

    public void Lose()
    {
        if (!gameOver)
        {           
            gameOver = true;
            loseText.text = "He got away";
        }
       
    }
}
