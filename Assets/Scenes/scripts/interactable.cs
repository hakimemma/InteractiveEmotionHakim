using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactkey;
    public UnityEvent interactAction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(isInRange) 
         if(Input.GetKeyDown(interactkey))
         {
                interactAction.Invoke();
         }
    }     
}
