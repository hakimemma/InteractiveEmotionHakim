using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    [SerializeField] Transform destination;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(destination.position, .4f);
        var direction = destination.TransformDirection(Vector3.forward);
        Gizmos.DrawRay(destination.position, direction);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDING");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.transform.position = destination.position;
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
   