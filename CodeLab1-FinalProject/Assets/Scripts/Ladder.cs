using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Ladder : MonoBehaviour
{
    public GameObject LookTarget;
    public GameObject TEbutton;
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        TEbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if(Camera.main.transform.position.z <= -23.86f && Camera.main.transform.position.z >= -30.76f&&Camera.main.transform.position.z>LookTarget.transform.position.z)
            {
                Camera.main.transform.Translate(0f, 0.5f,4.28f);
                LookTarget.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 15f, Camera.main.transform.position.z - 15f);
                TEbutton.SetActive(true);
                Up.SetActive(false);
                if (Down != null)
                {
                    Down.SetActive(false);
                }
                if (Left != null)
                {
                    Left.SetActive(false);
                }
                if (Right != null)
                {
                    Right.SetActive(false);
                }
                if (GetComponent<Collider>() != null)
                {
                    Destroy(GetComponent<Collider>());
                }
            }
            else
            {
                text.text = "I can't reach it";
            }
        }
    }
}
