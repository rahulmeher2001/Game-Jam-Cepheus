using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostBoxPickup : MonoBehaviour
{
    //GameObject GM = GameObject.FindGameObjectWithTag("GameManager");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collidedObject)
    {
        /*
        if (collidedObject.gameObject.tag == "Lost")
        {
            Destroy(collidedObject.gameObject);

            GM.GetComponent<lostBoxPickup>();
        }
        */
    }
}
