using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ToTheMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
