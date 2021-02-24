using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public void selectCar()
    {
        SceneManager.LoadScene(2);
        GlobalCar.carType = 1;
    }
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void credits()
    {
        SceneManager.LoadScene(3);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        
        Application.Quit();
        
    }
}
