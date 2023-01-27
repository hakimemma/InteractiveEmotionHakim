using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    public TextMeshProUGUI Collected;
    public int amount = 0;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {

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
                if(amount == 5)
                {
                    DestroyWall();
                }
                else
                {
                    amount += amount + 1;
                    amount = amount;
                    Collected.text = "Collected " + amount;
                    Destroy(gameObject);
                    Debug.Log("Added");
                    Debug.Log(amount);
                }
            }
        }
    }
    void DestroyWall()
    {        
        Destroy(wall);
    } 
} 

