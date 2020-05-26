using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickOnDoorScript2 : MonoBehaviour
{
    public GameObject buttonManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0)&& !EventSystem.current.IsPointerOverGameObject())//Clicked and not over UI elements
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            buttonManager.GetComponent<ChangeScenes>().MoveForward();

        }

    }
}
