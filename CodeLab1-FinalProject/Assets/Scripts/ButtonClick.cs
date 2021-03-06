﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public Transform mainCamera;
    public Transform targetCube;
    public float distance = 15;
    //public float xPosition;
    public float yPosition;
    //public float zPosition;
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
    // Start is called before the first frame update
    void Start()
    {
        targetCube.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, mainCamera.transform.position.z + distance);
    }

    public void LookUp()
    {
        targetCube.transform.Translate(0f, yPosition, 0f);
        //targetCube.transform.position = new Vector3(Cx, Cy + yPosition, Cz);
        if (targetCube.transform.position.y == mainCamera.transform.position.y)
        {
            Up.SetActive(true);
            Left.SetActive(true);
            Right.SetActive(true);
            Down.SetActive(true);
        }
        else
        {
            Up.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(true);
            Down.SetActive(true);
        }
    }
    public void LookDown()
    {
        targetCube.transform.Translate(0f, -yPosition, 0f);
        //targetCube.transform.position = new Vector3(transform.position.x, transform.position.y - yPosition, transform.position.z);
        if (targetCube.transform.position.y == mainCamera.transform.position.y)
        {
            Up.SetActive(true);
            Left.SetActive(true);
            Right.SetActive(true);
            Down.SetActive(true);
        }
        else
        {
            Up.SetActive(true);
            Left.SetActive(true);
            Right.SetActive(true);
            Down.SetActive(false);
        }   
    }
    public void LookLeft()
    {
        if (targetCube.transform.position.x == mainCamera.transform.position.x- distance && targetCube.transform.position.z== mainCamera.transform.position.z)//left side
        {
            //targetCube.transform.Translate(distance, 0f, -distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x, targetCube.transform.position.y, mainCamera.transform.position.z - distance);
            Debug.Log("Turn left1");
        }
        else if(targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z+ distance)//front side
        {
            //targetCube.transform.Translate(-distance, 0f, -distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x - distance, targetCube.transform.position.y, mainCamera.transform.position.z);
            Debug.Log("Turn left2");
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z <= mainCamera.transform.position.z - distance)//back side
        {
            //targetCube.transform.Translate(distance, 0f, distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x + distance, targetCube.transform.position.y, mainCamera.transform.position.z);
            Debug.Log("Turn left3");
        }
        else if(targetCube.transform.position.x == mainCamera.transform.position.x + distance && targetCube.transform.position.z == mainCamera.transform.position.z)//right side
        {
            //targetCube.transform.Translate(-distance, 0f, distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x, targetCube.transform.position.y, mainCamera.transform.position.z + distance);
            Debug.Log("Turn left4");
        }
        if (targetCube.transform.position.y <= mainCamera.transform.position.y)
        {
            Up.SetActive(true);
        }
        else
        {
            Up.SetActive(false);
        }
        
        Left.SetActive(true);
        Right.SetActive(true);
        if (targetCube.transform.position.y >= mainCamera.transform.position.y)
        {
            Down.SetActive(true);
        }
        else
        {
            Down.SetActive(false);
        }
        
    }
    public void LookRight()
    {
        if (targetCube.transform.position.x == mainCamera.transform.position.x - distance && targetCube.transform.position.z == mainCamera.transform.position.z)//left side
        {
            //targetCube.transform.Translate(distance, 0f, distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x, targetCube.transform.position.y, mainCamera.transform.position.z + distance);
            Debug.Log("Turn right1");
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z+ distance)//front side
        {
            //targetCube.transform.Translate(distance, 0f, -distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x + distance, targetCube.transform.position.y, mainCamera.transform.position.z);
            Debug.Log("Turn right2");
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z <= mainCamera.transform.position.z - distance)//back side
        {
            //targetCube.transform.Translate(-distance, 0f, distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x - distance, targetCube.transform.position.y, mainCamera.transform.position.z);
            Debug.Log("Turn right3");
        }
        else if(targetCube.transform.position.x == mainCamera.transform.position.x + distance && targetCube.transform.position.z == mainCamera.transform.position.z)//right side
        {
            //targetCube.transform.Translate(-distance, 0f, -distance);
            targetCube.transform.position = new Vector3(mainCamera.transform.position.x, targetCube.transform.position.y, mainCamera.transform.position.z - distance);
            Debug.Log("Turn right4");
        }
        if (targetCube.transform.position.y <= mainCamera.transform.position.y)
        {
            Up.SetActive(true);
        }
        else
        {
            Up.SetActive(false);
        }
        Left.SetActive(true);
        Right.SetActive(true);
        if (targetCube.transform.position.y >= mainCamera.transform.position.y)
        {
            Down.SetActive(true);
        }
        else
        {
            Down.SetActive(false);
        }
    }
}
