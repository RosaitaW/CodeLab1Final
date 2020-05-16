using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDragPainting : MonoBehaviour
{
    float mouseZPos; //holds the mouse position of the object
    Rigidbody rb; //holds the Rigidbody
    Collider col; //holds the Collider
    public SpriteRenderer PaintingSprite;
    public Sprite sprite0;
    public Sprite sprite1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //get the rigidbody component
        col = GetComponent<Collider>(); //get the collider component
        PaintingSprite = GetComponent<SpriteRenderer>();
        PaintingSprite.sprite = sprite0;
    }
    void OnMouseDrag()
    { //if you drag the mouse over the gameObject
        mouseZPos = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; //get the Z position of the object at the screen

        rb.isKinematic = true; //make it uneffected by physics
        rb.MovePosition(GetMouseAsWorldPoint()); //move it to the new mouse position

        col.enabled = false; //turn off the collider
    }

    private void OnMouseUp() //if you release the mouse over the object
    {
        col.enabled = true; //trun on collisions
        rb.useGravity = true;
        if (PaintingSprite.sprite == sprite0)
        {
            PaintingSprite.sprite = sprite1;
        }
    }

    Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition; //Pixel coordinates of mouse (x,y)

        mousePoint.z = mouseZPos; //z coordinate of gameObject on screen

        return Camera.main.ScreenToWorldPoint(mousePoint);  //Convert it to world points
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
