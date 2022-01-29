using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public Transform[] patrolpos;
    private int x;
    public float speed;

    private void Start()
    {
        x = 1;
    }

    private void Update()

    {
        transform.position = Vector3.MoveTowards(transform.position, patrolpos[x].position, speed * Time.deltaTime);
        transform.LookAt(patrolpos[x]);
        if(Vector3.Distance(transform.position, patrolpos[x].position) < 0.2f)
        {
            if (x != 0)
            {
                x = 0;
               
            }

            else
            {
                x = 1;
            }
        }
    }

}
