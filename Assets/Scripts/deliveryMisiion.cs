using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliveryMisiion : MonoBehaviour
{
    public GameObject Mission;
    private bool ifdialogue;



    private void Update()
    {


        {
            if (ifdialogue)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Mission.SetActive(true);

                }
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

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "dialogue")
        {
            ifdialogue = false;
        }
    }

}
