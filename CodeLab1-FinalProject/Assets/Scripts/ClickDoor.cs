using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDoor : MonoBehaviour
{
    public GameObject keyManager;
    public bool isUnlocked = false;
    public bool isOpen = false;
    public Text What2Do;
    public GameObject ExitButton;
    public GameObject Looktarget;
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (keyManager.GetComponent<KeyManager>().CountNumber == 0 && !isOpen)
        {
            isUnlocked = true;
            What2Do.text = "I should check the door now";
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            if (isUnlocked && Looktarget.transform.position.y==0)
            {
                isOpen = true;
                gameObject.transform.Rotate(Vector3.up, 90f);
                What2Do.text = "The door is opened";
                ExitButton.SetActive(true);
                Up.SetActive(false);
                Left.SetActive(false);
                Right.SetActive(false);
                Down.SetActive(false);
                Debug.Log("Is opened");
                if (gameObject.GetComponent<BoxCollider>() != null)
                {
                    Destroy(gameObject.GetComponent<BoxCollider>());
                    Debug.Log("Can't close anymore");
                }
            }
            else if (isUnlocked && Looktarget.transform.position.y != 0)
            {
                return;
            }else
            {
                What2Do.text = "It's locked";
            }
            
        }

    }
}
