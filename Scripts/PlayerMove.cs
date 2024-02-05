using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 6.0f;
    private float gravity = -9.8f;

    private CharacterController charController;
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal") * speed;
        float MoveZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(MoveX, 0, MoveZ);

        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);
        charController.Move(movement);

        //transform.Translate(MoveX * Time.deltaTime, 0, 0);
        //transform.Translate(0, 0, MoveZ * Time.deltaTime);
    }
}
