using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemovement : MonoBehaviour
{
    public float MouseSensitivity = 100f;
    public Transform player;
    float Xrotation = 0f;
    private bool onui;
    public DailougeManager dm;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        onui = dm.uiisactive;
    }

    // Update is called once per frame
    void Update()
    {
        onui = dm.uiisactive;
        

        if (!onui)
        {
            float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
            float mousey = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
            player.Rotate(Vector3.up * mouseX);
            Xrotation -= mousey;
            Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(Xrotation, 0f, 0f);
            Cursor.lockState = CursorLockMode.Locked;
        }

        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
