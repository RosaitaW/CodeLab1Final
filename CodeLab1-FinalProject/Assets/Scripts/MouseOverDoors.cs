using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverDoors : MonoBehaviour
{
    public Text text;
    public GameObject MainCamera;
    public GameObject ButtonManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if(!ButtonManager.GetComponent<ChangeScenes>().IsClickBack && !ButtonManager.GetComponent<ChangeScenes>().IsClickForward)
        {
            if (-35.76 <= MainCamera.transform.position.z && MainCamera.transform.position.z <= -10.3)
            {
                text.text = "Click to step closer";
                Debug.Log("Ready to click");
            }
        }
        else
        {
            return;
        }
        Debug.Log("Mouse is over the door");
    }
    private void OnMouseExit()
    {
        text.text = "Escape the hallway";
        Debug.Log("Mouse exited");
    }
}
