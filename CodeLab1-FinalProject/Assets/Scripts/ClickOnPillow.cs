using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPillow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            this.gameObject.transform.Translate(0f, -3f, 0f);
            if (gameObject.GetComponent < BoxCollider> () != null){
                Destroy(gameObject.GetComponent<BoxCollider>());
            } 
        }

    }
}
