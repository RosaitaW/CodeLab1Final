using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokeByHand : MonoBehaviour
{
    public GameObject ForkPainting;
    public Text text;
    public Sprite sprite0;
    public Sprite sprite1;
    public bool IsPoked;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite0;
        IsPoked = false;
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
            if (!ForkPainting.GetComponent<GettingFork>().TookFork)
            {
                text.text = "I'm not touching it";
                Debug.Log("Need the fork");
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = sprite1;
                text.text = "Something screamed";
                IsPoked = true;
                if (gameObject.GetComponent<BoxCollider>() != null)
                {
                    Destroy(gameObject.GetComponent<BoxCollider>());
                }
            }
        }
    }
}
