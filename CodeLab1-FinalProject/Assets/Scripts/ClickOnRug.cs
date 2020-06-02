using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickOnRug : MonoBehaviour
{
    public Collider FloorRugCollider;
    public SpriteRenderer FloorRugSprite;
    public Sprite sprite0;
    public Sprite sprite1;
    //Ray myRay = new Ray();
    // Start is called before the first frame update
    void Start()
    {
        FloorRugCollider = GetComponent<Collider>();
        FloorRugSprite = GetComponent<SpriteRenderer>();
        FloorRugSprite.sprite = sprite0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if(hit.collider== FloorRugCollider)
                {
                    if (FloorRugSprite.sprite == sprite0)
                    {
                        FloorRugSprite.sprite = sprite1;
                        if (gameObject.GetComponent<BoxCollider>() != null)
                        {
                            Destroy(gameObject.GetComponent<BoxCollider>());
                        }
                    }
                }
            }
        }
    }
    
}
