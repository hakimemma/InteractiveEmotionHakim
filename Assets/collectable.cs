using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    public TextMeshProUGUI Collected;
    public GameObject wall;
    public KeyCounter counter;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = FindObjectOfType<KeyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation= Quaternion.Euler(90f,Time.time*100f,0);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                if(counter.keyAmount == 5)
                {
                    DestroyWall();
                }
                else if(counter.keyAmount < 5)
                {
                    counter.keyAmount = counter.keyAmount + 1;
                    Collected.text = "Collected " + counter.keyAmount;
                    Destroy(gameObject);
                    Debug.Log("Added");
                    Debug.Log(counter.keyAmount);
                }
            }
        }
    }
    void DestroyWall()
    {        
        Destroy(wall);
    } 
} 

