using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnGoldfish : MonoBehaviour
{
    public Sprite sprite0;
    public Sprite sprite1;
    public GameObject key;
    public GameObject Tank;
    public GameObject Tank1;
    public GameObject Tank2;
    public GameObject Tank3;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);       
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
            SpriteRenderer tank = Tank.transform.GetComponent<SpriteRenderer>();
            tank.sprite = sprite1;
            SpriteRenderer tank1 = Tank1.transform.GetComponent<SpriteRenderer>();
            tank1.sprite = sprite1;
            SpriteRenderer tank2 = Tank2.transform.GetComponent<SpriteRenderer>();
            tank2.sprite = sprite1;
            SpriteRenderer tank3 = Tank3.transform.GetComponent<SpriteRenderer>();
            tank3.sprite = sprite1;
            Destroy(gameObject);
            key.SetActive(true);
        }

    }
}
