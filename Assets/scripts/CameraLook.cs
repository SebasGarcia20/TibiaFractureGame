using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSentitivity = 80f;
    public Transform playerBody;
    
    float xRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSentitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSentitivity*Time.deltaTime;

        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation, -90f,90);

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up*mouseX);


    }
}
