using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void PlayGames ()
    {
        SceneManager.LoadScene("Demo"); 
    }
    public void QuitGames ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
