﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class door06 : MonoBehaviour
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

            if (MainCamera.transform.position.z >= -25.48 && MainCamera.transform.position.z < -15.16f)
            {
                if (SideDoorsManager.GetComponent<SideDoorsManager>().door06)//if door04 is unlocked
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = null;
                    text.text = "The door disappeared in darkness";
                    if (gameObject.GetComponent<BoxCollider>() != null)//if the door has collider
                    {
                        Destroy(gameObject.GetComponent<BoxCollider>());//destroy the collider
                        Debug.Log("Opened door04");
                    }
                }
                else
                {
                    text.text = "It's locked";
                    Debug.Log("Door06 is still locked");
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
