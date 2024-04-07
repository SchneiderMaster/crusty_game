using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanMove : MonoBehaviour
{

    public Camera cam;

    public float speed;

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        isGrounded = Physics.Raycast(this.transform.position, Vector3.down, out hit, 9.2f);



        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, speed * 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -speed * 0.01f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed * 0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed * 0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            this.GetComponent<Rigidbody>().AddForce(0, 1000, 0);
        }
        
        if (Cursor.lockState.Equals(CursorLockMode.Locked))
        {
            this.transform.Rotate(0 , Input.GetAxisRaw("Mouse X"), 0);
        }






    }
}
