using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class unifiedMovement : NetworkBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public GameObject clientCam;
    public Transform cam;
    float rotationX = 0f;
    public float gravity = -9.81f;
    public float lookSpeed = 2.0f;


    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isLocalPlayer)//Anything in this statement is only run for the localplayer (for movement and such)
        {
            velocity.y = gravity;
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
            controller.Move(velocity * Time.deltaTime);

            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;

            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            clientCam.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);

        }
        else
        {
            clientCam.gameObject.SetActive(false);//makes sure the camera is only used by the player
        }
    }
}

