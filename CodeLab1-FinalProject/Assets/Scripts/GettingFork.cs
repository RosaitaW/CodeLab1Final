using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GettingFork : MonoBehaviour
{
    public SpriteRenderer spr;
    public Sprite sprite0;
    public Sprite sprite1;
    public bool TookFork=false;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = sprite0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())//Clicked and not over UI elements
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            if (!TookFork)
            {
                TookFork = true;
                spr.sprite = sprite1;
                if (gameObject.GetComponent<BoxCollider>() != null)
                {
                    Destroy(gameObject.GetComponent<BoxCollider>());
                }
            }

        }

    }
}
