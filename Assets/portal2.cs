using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal2 : MonoBehaviour
{

    [SerializeField] Transform destination;
    public Transform player;
    //PlayerMovement pc;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.transform.position = destination.transform.position;
        }
    }
}
