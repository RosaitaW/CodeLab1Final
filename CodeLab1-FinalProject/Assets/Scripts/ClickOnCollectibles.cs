using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickOnCollectibles : MonoBehaviour
{
    private float Posx;
    private float Posy;
    public bool IsCollected=false;
    Rigidbody2D rb;
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            Destroy(gameObject);
            if (IsCollected==false)
            {
                IsCollected=true;
                Debug.Log("Collected");
            }
        }

    }
}
