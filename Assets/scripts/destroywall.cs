using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywall : MonoBehaviour
{
    KeyCounter keyCounter;
    void Start()
    {
        keyCounter = FindObjectOfType<KeyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (keyCounter.keyAmount == 5)
        {
            Destroy(gameObject);
        }

    }   
}
