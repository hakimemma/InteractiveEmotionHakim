using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showui : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
     uiObject.SetActive(false);   
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider player)
    {
      if (player.gameObject.tag == "player")  
      {
       uiObject.SetActive(true);
       StartCoroutine("WaitForSec");
    
      }  
    }
    IEnumerator WaitForSec()
    {
       yield return new WaitForSeconds(5);
       Destroy(uiObject);
       Destroy(gameObject);
    }
}   


