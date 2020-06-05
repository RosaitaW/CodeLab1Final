using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chain : MonoBehaviour
{
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Text text;
    bool IsPulled;
    public bool IsPulled2;
    public GameObject eyesManager;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite0;
        IsPulled = false;
        IsPulled2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (eyesManager.GetComponent<EyeballsManager>().AllPoked)
        {
            if (!IsPulled2)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;
            }
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            if (!eyesManager.GetComponent<EyeballsManager>().AllPoked)
            {
                if (!IsPulled)
                {
                    IsPulled = true;
                    GetComponent<SpriteRenderer>().sprite = sprite1;
                    text.text = "It's stucked";
                }
            }
            else
            {
                if (!IsPulled2)
                {
                    GetComponent<SpriteRenderer>().sprite = sprite3;
                    IsPulled2 = true;
                    text.text = "Something unlocked";
                }
                
            }
        }
    }
}
