using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDialogue : MonoBehaviour
{
    private bool ifdialogue=false;
    // Update is called once per frame\
    

    void Update()
    {
        if (ifdialogue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

            } 
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dialogue")
        {
            ifdialogue = true;
        }
    }
}
