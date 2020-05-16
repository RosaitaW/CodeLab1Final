using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ClickAndDrag : MonoBehaviour
{
    private float Posx;
    private float Posy;
    private bool IsBeingHeld=false;
    public GameObject Painting;
    public SpriteRenderer PaintingSprite;
    public Sprite sprite0;
    public Sprite sprite1;

    // Update is called once per frame
    void Start()
    {
        PaintingSprite = GetComponent<SpriteRenderer>();
        PaintingSprite.sprite = sprite0;
    }
    void Update()
    {
        if (IsBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x-Posx, mousePos.y-Posy, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 8.46f);
            Posx = mousePos.x - this.transform.localPosition.x;
            Posy = mousePos.y - this.transform.localPosition.y;
            IsBeingHeld = true;
        }
        
    }
    private void OnMouseUp()
    {
        IsBeingHeld = false;
        if (PaintingSprite.sprite == sprite0)
        {
            PaintingSprite.sprite = sprite1;
        }
    }
}
