using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    private int axes;

    private float Hspeed = 6.0f;

    private float VSpeed = 6.0f;

    private float minVert = -45.0f;

    private float maxVert = 45.0f;

    private float vertRotation = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(axes == 1)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * Hspeed, 0);
        }
        else if(axes == 2)
        {
            vertRotation -= Input.GetAxis("Mouse Y") * VSpeed;
            vertRotation = Mathf.Clamp(vertRotation, minVert, maxVert);

            float HRoatation = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(vertRotation, HRoatation, 0);
        }
        else
        {
            vertRotation -= Input.GetAxis("Mouse Y") * VSpeed;
            vertRotation = Mathf.Clamp(vertRotation, minVert, maxVert);

            float delta = Input.GetAxis("Mouse X") * Hspeed;
            float HRotation = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(vertRotation, HRotation, 0);
        }
       
    }
}
