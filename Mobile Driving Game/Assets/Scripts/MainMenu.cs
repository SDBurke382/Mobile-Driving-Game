using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;    

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
        StartButton();
        QuitButton();
    }

    private void MainMenuButton()
    {
        throw new NotImplementedException();
    }

    public void StartButton()
    {
        
        SceneManager.LoadScene("Mobile Level");
    }    

    public void QuitButton()
    {
        
        Application.Quit();
    }
}
