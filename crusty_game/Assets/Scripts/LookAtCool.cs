using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCool : MonoBehaviour
{

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(new Vector3(cam.transform.position.x, this.transform.position.y, cam.transform.position.z));
        this.transform.Rotate(0, 180, 0);
    }
}
