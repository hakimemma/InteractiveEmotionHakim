using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    PlayerMovement pm;
    public GameObject uiObject;
    bool setTimer = false;
    float time = 5.0f;

    void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        uiObject.SetActive(false);   
    }

    private void Update()
    {
        if (setTimer == true)
        {
            time = time - Time.deltaTime;
        }

        if (time < 0f)
        {
            pm.playerMovement = true;
            Debug.Log("I am running");
            Destroy(gameObject);
            Destroy(uiObject);
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            pm.playerMovement = false;
            uiObject.SetActive(true);
            setTimer = true;
        }
    }

}   




