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
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                if(counter.keyAmount < 15)
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
}



