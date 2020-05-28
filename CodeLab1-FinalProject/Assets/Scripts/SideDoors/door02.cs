using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class door02 : MonoBehaviour
{
    public GameObject SideDoorsManager;
    public Text text;
    public GameObject MainCamera;
    //public GameObject ThisWall;

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())//click on the door
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            if (MainCamera.transform.position.z >= -15.16f)
            {
                if (!SideDoorsManager.GetComponent<SideDoorsManager>().door02)
                {
                    text.text = "It's locked";
                    Debug.Log("Door02 is still locked");
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = null;
                    text.text = "The door disappeared in darkness";
                    if (!SideDoorsManager.GetComponent<SideDoorsManager>().door03)
                    {
                        SideDoorsManager.GetComponent<SideDoorsManager>().door03 = true;
                    }
                    if (gameObject.GetComponent<BoxCollider>() != null)//if the door has collider
                    {
                        Destroy(gameObject.GetComponent<BoxCollider>());//destroy the collider
                        Debug.Log("Opened door02");
                    }
                }
            }
            else
            {
                text.text = "I can't reach it";
                Debug.Log("Step closer");
            }
            
        }
    }
}
