using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal2 : MonoBehaviour
{

    [SerializeField] Transform destination;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) && other.TryGetComponent<Player>(out var player))
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(destination.position, .4f);
        var direction = destination.TransformDirection(Vector3.forward);
        Gizmos.DrawRay(destination.position, direction);
    }
}
