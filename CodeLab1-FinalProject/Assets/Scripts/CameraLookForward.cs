using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookForward : MonoBehaviour
{
    public Transform target;
    public float timeMod = 0.1f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        { 
            return;//No target, no functions
        }
        //Look at the target
        Vector3 forward = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * timeMod);
        Debug.DrawLine(transform.position, target.position, Color.red);
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.blue);
    }
}
