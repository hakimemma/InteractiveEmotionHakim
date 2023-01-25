using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    public TextMeshProUGUI Collected;
    public int amount = 0;

    // Update is called once per frame
    void Update()
    {
     transform.localRotation = Quaternion.Euler(90f, Time.time * 100f,0);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                amount++;
                Collected.text = "Collected:" + amount;
                Destroy(gameObject);
                Debug.Log("Added");
            }
            Debug.Log("This is a player");
        }
    }
}

