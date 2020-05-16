using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    public GameObject key0;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;
    public GameObject lock0;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public float CountNumber;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        text.text ="Need key number: "+CountNumber;
        if (CountNumber > 0)
        {
            if (key0 != null && lock0 != null)
            {
                if(key0.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key0.SetActive(false);
                    lock0.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }
            }
            if (key1 != null && lock1 != null)
            {
                if(key1.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key1.SetActive(false);
                    lock1.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }                
            }
            if (key2 != null && lock2 != null)
            {
                if (key2.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key2.SetActive(false);
                    lock2.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }
            }
            if (key3 != null && lock3 != null)
            {
                if (key3.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key3.SetActive(false);
                    lock3.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }
            }
            if (key4 != null && lock4 != null)
            {
                if (key4.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key4.SetActive(false);
                    lock4.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }
            }
            if (key5 != null && lock5 != null)
            {
                if (key5.GetComponent<ClickOnCollectibles>().IsCollected)
                {
                    key5.SetActive(false);
                    lock5.SetActive(false);
                    CountNumber -= 1;
                    Debug.Log("Count number: " + CountNumber);
                }
            }
        }

    }
}
