using System.Collections;
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
            Left.SetActive(false);
            Right.SetActive(false);
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
            Left.SetActive(false);
            Right.SetActive(false);
            Down.SetActive(false);
        }   
    }
    public void LookLeft()
    {
        if (targetCube.transform.position.x == mainCamera.transform.position.x- distance && targetCube.transform.position.z== mainCamera.transform.position.z)//left side
        {
            targetCube.transform.Translate(distance, 0f, -distance);
        }
        else if(targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z+ distance)//front side
        {
            targetCube.transform.Translate(-distance, 0f, -distance);
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z - distance)//back side
        {
            targetCube.transform.Translate(distance, 0f, distance);
        }
        else//right side
        {
            targetCube.transform.Translate(-distance, 0f, distance);
        }
        Up.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Down.SetActive(true);
    }
    public void LookRight()
    {
        if (targetCube.transform.position.x == mainCamera.transform.position.x - distance && targetCube.transform.position.z == mainCamera.transform.position.z)
        {
            targetCube.transform.Translate(distance, 0f, distance);
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z+ distance)
        {
            targetCube.transform.Translate(distance, 0f, -distance);
        }
        else if (targetCube.transform.position.x == mainCamera.transform.position.x && targetCube.transform.position.z == mainCamera.transform.position.z - distance)
        {
            targetCube.transform.Translate(-distance, 0f, distance);
        }
        else
        {
            targetCube.transform.Translate(-distance, 0f, -distance);
        }
        Up.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Down.SetActive(true);
    }
}
