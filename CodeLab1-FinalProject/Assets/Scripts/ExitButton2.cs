using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton2 : MonoBehaviour
{
    public GameObject ExitButton;
    public GameObject ButtonManager;
    public GameObject LookTarget;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonManager.GetComponent<ChangeScenes>().IsExitOpened&&LookTarget.transform.position.z <= -(35.76f+15f)){
            ExitButton.SetActive(true);
            Debug.Log("Can leave now");
        }
        else
        {
            ExitButton.SetActive(false);
        }
    }
}
