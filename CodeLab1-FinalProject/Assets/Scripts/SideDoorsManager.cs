using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideDoorsManager : MonoBehaviour
{
    public bool door01;
    public bool door02;
    public bool door03;
    public bool door04;
    public bool door05;
    public bool door06;

    // Start is called before the first frame update
    void Start()
    {
        door01 = true;
        door02 = false;
        door03 = false;
        door04 = false;
        door05 = false;
        door06 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
