using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public CharacterController PlayerHeight;
    public CapsuleCollider playerCol;
    public float normalHeight, crouchHeight;
<<<<<<< HEAD
    bool Crouching = false;
    
    void Update(){
        if(Input.GetKey(KeyCode.C) && Crouching == false)
        {
            PlayerHeight.height = crouchHeight;
            Crouching = true;
            Debug.Log("RO");
        }
        if(Input.GetKey(KeyCode.C) && Crouching == true)
        {
             PlayerHeight.height = normalHeight;
             Debug.Log("OG");
             Crouching = false;
        }   
    }
    
        
    
=======
    public Transform player;
    public Vector3 offset;
    public bool crouched;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)){
            crouched = !crouched;
            if (crouched)
            {
                transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
                //PlayerHeight.height = crouchHeight;
                //playerCol.height = crouchHeight;
                //player.position = player.position + offset;

            } else
            {
                transform.localScale = new Vector3(transform.localScale.x, normalHeight, transform.localScale.z);
                //PlayerHeight.height = normalHeight;
                //playerCol.height = normalHeight;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.C)){
            
        } 

    }    









>>>>>>> 874b5be0b9e6704823a9612043b0a03676555176
}

