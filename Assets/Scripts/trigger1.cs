using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{
    public Dailouge dailouge;
     public bool ifdialogue = false;

    private void Update()
    {
        

        {
            if (ifdialogue)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    TriggerDialogue();
                }
            }
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DailougeManager>().StartDialogue(dailouge);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dialogue")
        {
            ifdialogue = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "dialogue")
        {
            ifdialogue = false;
        }
    }


}
