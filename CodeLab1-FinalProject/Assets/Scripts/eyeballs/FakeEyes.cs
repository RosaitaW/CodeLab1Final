using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FakeEyes : MonoBehaviour
{
    public GameObject trueEye;
    public GameObject GettingFork;
    public Sprite sprite0;
    public Sprite sprite1;
    public bool IsBleed;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite0;
        IsBleed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trueEye.GetComponent<PokeByHand>().IsPoked)
        {
            if(GetComponent<SpriteRenderer>().sprite != sprite1)
            {
                GetComponent<SpriteRenderer>().sprite = sprite1;
            }
            else
            {
                return;
            }
        }
       
    }
    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToViewportPoint(mousePos);
        if (Input.GetMouseButton(0))
        {
            if (!trueEye.GetComponent<PokeByHand>().IsPoked)
            {
                if (!GettingFork.GetComponent<GettingFork>().TookFork)
                {
                    trueEye.GetComponent<PokeByHand>().OnMouseDown();
                }
                else
                {
                    if (!IsBleed)
                    {
                        text.text = "Ouch! It bited me! ";
                        IsBleed = true;
                    }
                    else
                    {
                        text.text = "Not again";
                    }
                }
                
                

            }
        }
    }
}
