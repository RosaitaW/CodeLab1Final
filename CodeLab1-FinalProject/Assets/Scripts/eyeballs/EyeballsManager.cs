using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeballsManager : MonoBehaviour
{
    public GameObject eye01;
    public GameObject eye02;
    public GameObject eye03;
    public GameObject eye04;
    public GameObject eye05;
    public bool IsPoked01;
    public bool IsPoked02;
    public bool IsPoked03;
    public bool IsPoked04;
    public bool IsPoked05;
    public bool AllPoked;
    // Start is called before the first frame update
    void Start()
    {
        IsPoked01 = false;
        IsPoked02 = false;
        IsPoked03 = false;
        IsPoked04 = false;
        IsPoked05 = false;
        AllPoked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (eye01.GetComponent<PokeByHand>().IsPoked)
        {
            if (!IsPoked01)
            {
                IsPoked01 = true;
                Debug.Log("01 poked");
            }
        }
        if (eye02.GetComponent<PokeByHand>().IsPoked)
        {
            if (!IsPoked02)
            {
                IsPoked02 = true;
                Debug.Log("02 poked");
            }
        }
        if (eye03.GetComponent<PokeByHand>().IsPoked)
        {
            if (!IsPoked03)
            {
                IsPoked03 = true;
                Debug.Log("03 poked");
            }
        }
        if (eye04.GetComponent<PokeByHand>().IsPoked)
        {
            if (!IsPoked04)
            {
                IsPoked04 = true;
                Debug.Log("04 poked");
            }
        }
        if (eye05.GetComponent<PokeByHand>().IsPoked)
        {
            if (!IsPoked05)
            {
                IsPoked05 = true;
                Debug.Log("05 poked");
            }
        }
        if (IsPoked01 && IsPoked02 && IsPoked03 && IsPoked04 && IsPoked05)
        {
            if (!AllPoked)
            {
                AllPoked = true;
                Debug.Log("All poked");
            }
        }
    }
}
