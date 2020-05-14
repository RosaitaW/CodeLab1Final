using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public Transform targetCube;
    public float xPosition;
    public float yPosition;
    public float zPosition;
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void LookUp()
    {
        targetCube.transform.Translate(0f, yPosition, 0f);
        //targetCube.transform.position = new Vector3(Cx, Cy + yPosition, Cz);
        if (targetCube.transform.position.y == 0)
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
        if (targetCube.transform.position.y == 0)
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
        if (targetCube.transform.position.x == -15 && targetCube.transform.position.z==0)
        {
            targetCube.transform.Translate(xPosition, 0f, -zPosition);
        }
        else if(targetCube.transform.position.x == 0 && targetCube.transform.position.z == 15)
        {
            targetCube.transform.Translate(-xPosition, 0f, -zPosition);
        }
        else if (targetCube.transform.position.x == 0 && targetCube.transform.position.z == -15)
        {
            targetCube.transform.Translate(xPosition, 0f, zPosition);
        }
        else
        {
            targetCube.transform.Translate(-xPosition, 0f, zPosition);
        }
        Up.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Down.SetActive(true);
    }
    public void LookRight()
    {
        if (targetCube.transform.position.x == -15 && targetCube.transform.position.z == 0)
        {
            targetCube.transform.Translate(xPosition, 0f, zPosition);
        }
        else if (targetCube.transform.position.x == 0 && targetCube.transform.position.z == 15)
        {
            targetCube.transform.Translate(xPosition, 0f, -zPosition);
        }
        else if (targetCube.transform.position.x == 0 && targetCube.transform.position.z == -15)
        {
            targetCube.transform.Translate(-xPosition, 0f, zPosition);
        }
        else
        {
            targetCube.transform.Translate(-xPosition, 0f, -zPosition);
        }
        Up.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Down.SetActive(true);
    }
}
