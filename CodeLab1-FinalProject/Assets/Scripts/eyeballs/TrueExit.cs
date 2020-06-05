using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueExit : MonoBehaviour
{
    public GameObject chain;
    public GameObject ExitDoor;
    public Sprite sprite0;
    public Sprite sprite1;
    public bool IsOpened;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        ExitDoor.GetComponent<SpriteRenderer>().sprite = sprite0;
        IsOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOpened)
        {
            if (Camera.main.transform.position.z >= ExitDoor.transform.position.z)
            {
                if (ExitDoor.GetComponent<SpriteRenderer>().sprite != sprite1)
                {
                    ExitDoor.GetComponent<SpriteRenderer>().sprite = sprite1;
                    ExitDoor.GetComponent<SpriteRenderer>().sortingOrder=0;
                }
            }
            else
            {
                ExitDoor.GetComponent<SpriteRenderer>().sprite = sprite0;
                ExitDoor.GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            if(Camera.main.transform.position.z <= -23.5f && Camera.main.transform.position.z>=-30.76f)
            {
                if (!chain.GetComponent<Chain>().IsPulled2)
                {
                    text.text = "It's stucked";
                    Debug.Log("Not yet");
                }
                else
                {
                    text.text = "It's opened";
                    Debug.Log("Is opened");
                    ExitDoor.transform.Rotate(90f, 0f, 0f);
                    if (!IsOpened)
                    {
                        IsOpened = true;
                    }
                    if (ExitDoor.GetComponent<BoxCollider>() != null)
                    {
                        Destroy(ExitDoor.GetComponent<BoxCollider>());
                    }
                }
            }
            else
            {
                text.text = "I can't reach it";
            }
        }
        
    }
}
