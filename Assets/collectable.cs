using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public static event Action OnCollected;

    // Update is called once per frame
    void Update()
    {
      transform.localRotation = Quaternion.Euler(90f, Time.time * 100f,0);
    }

     
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);

        }





    }  
}

