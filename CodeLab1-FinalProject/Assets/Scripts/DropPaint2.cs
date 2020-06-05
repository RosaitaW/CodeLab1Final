using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropPaint2 : MonoBehaviour
{
    public GameObject Floor;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp() //if you release the mouse over the object
    {
        //col.enabled = true; //trun on collisions
        //rb.useGravity = true;
        if (Camera.main.transform.position.z > -25.48f)
        {
            text.text = "I can't reach it";
        }
        else
        {
            gameObject.transform.Translate(0f, Floor.transform.position.y - gameObject.transform.position.y + gameObject.GetComponent<BoxCollider>().size.y / 2f, 0f);
            gameObject.transform.Rotate(0f, 0f, 2f);
            text.text = "The painting dropped";
            if (gameObject.GetComponent<BoxCollider>() != null)
            {
                Destroy(gameObject.GetComponent<BoxCollider>());
                Debug.Log("Droped");
            }
        }  
    }
}
