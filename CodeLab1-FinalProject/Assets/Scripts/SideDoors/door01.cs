using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class door01 : MonoBehaviour
{
    public GameObject SideDoorsManager;
    public Text text;
    public GameObject MainCamera;
    public GameObject ThisWall;

    public void OnMouseDown()
    {
        if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject() && MainCamera.transform.position.z== -35.76f)//click on the door when standing in front of it
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            if (SideDoorsManager.GetComponent<SideDoorsManager>().door01)//if door01 is unlocked
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = null;
                text.text = "The door disappeared in darkness";
                if (!SideDoorsManager.GetComponent<SideDoorsManager>().door02)//if door02 is not unlocked
                {
                    SideDoorsManager.GetComponent<SideDoorsManager>().door02 = true;//unlock door02
                }
                if (gameObject.GetComponent<BoxCollider>() != null)//if the door has collider
                {
                    Destroy(gameObject.GetComponent<BoxCollider>());//destroy the collider
                    Debug.Log("Opened door01");
                }
            }
            /*else
            {
                text.text="I can't reach it";
                Debug.Log("Get closer");
            }*/
        }
    }
}
