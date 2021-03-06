﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GettingFork : MonoBehaviour
{
    public SpriteRenderer spr;
    public Sprite sprite0;
    public Sprite sprite1;
    public bool TookFork=false;
    public Text text;
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
                text.text = "A gold fork dropped in my hand";
                if (gameObject.GetComponent<BoxCollider>() != null)
                {
                    Destroy(gameObject.GetComponent<BoxCollider>());
                }
            }

        }

    }
}
