using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TrueEnding : MonoBehaviour
{
    public GameObject ExitDoor;
    public GameObject ExitLadder;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        ExitLadder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (ExitDoor.GetComponent<TrueExit>().IsOpened && !EventSystem.current.IsPointerOverGameObject())
        {
            text.text = "Check the trap door";
        }
    }
    void OnMouseExit()
    {
        text.text = "Escape the hallway";
    }
    private void OnMouseDown()
    {
        if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if(ExitDoor.GetComponent<TrueExit>().IsOpened)
            {
                if (Camera.main.transform.position.z <= -23.86f && Camera.main.transform.position.z >= -30.76f)
                {
                    ExitLadder.SetActive(true);
                    text.text = "A ladder dropped down";
                    Debug.Log("Ladder down");
                    if (GetComponent<BoxCollider>()!=null)
                    {
                        Destroy(GetComponent<BoxCollider>());
                    }
                }
                else
                {
                    text.text = "I can't reach it";
                }
            }
            
            
        }
    }
}
