using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerbody;

    float xRotation = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity; * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity; * Time.deltaTime;
      
      


      playerBody.Rotate(Vector3.up * mouseX);
    }
}
