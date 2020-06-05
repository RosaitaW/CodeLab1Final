using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    public float MovingDistance;
    public float CameraNewZ;
    public GameObject MainCamera;
    public Text text;
    public GameObject ExitDoor;
    public GameObject EscapeButton;
    //public GameObject EscapeButton2;
    public GameObject LookTarget;
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
    public bool IsClickBack=false;
    public bool IsClickForward=false;
    public bool IsExitOpened=false;
    // Start is called before the first frame update
    void Start()
    {
        //EscapeButton.SetActive(false);
        Room2.SetActive(false);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TrueEnding()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
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
    public void NextRoom()
    {
        MainCamera.transform.position =new Vector3(0f, 0f, -CameraNewZ);
        LookTarget.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z - 15);
        EscapeButton.SetActive(false);
        Room1.SetActive(false);
        Room2.SetActive(true);
        Up.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Down.SetActive(true);
        text.text = "Escape the hallway";
        text.GetComponent<Text>().color = Color.red;//or use "new Color(0-255,0-255,0-255,)to change color with RGB values"
        Debug.Log("Moved to a new place");
    }
    public void MoveBackward()
    {
        if (!IsClickBack)
        {
            IsClickBack = true;
        }
        if (MainCamera.transform.position.z >= -CameraNewZ)
        {
            text.text = "I'm not going back";
            Debug.Log("No turning back");
        }
        else
        {
            MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z + MovingDistance);
            LookTarget.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z + 15);
            text.text = "Moved back";
            if (IsExitOpened)
            {
                ExitDoor.transform.Rotate(Vector3.up, -90f);
                IsExitOpened = false;
            }
            Debug.Log("moved back");
        }
    }
    public void MoveForward()
    {
        Debug.Log("Distance=" + (-(CameraNewZ + 2 * MovingDistance)));
        if (!IsClickForward)
        {
            IsClickForward = true;
        }
        if (MainCamera.transform.position.z > -35.76f)
        {
            MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z - MovingDistance);
            LookTarget.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z - 15);
            text.text = "Moved forward";
            Debug.Log("moved forward");
        }
        else
        {
            
            ExitDoor.transform.Rotate(Vector3.up, 90f);
            IsExitOpened = true;
            text.text = "Leave?";
            Debug.Log("Leave?");
        }
    }

}
