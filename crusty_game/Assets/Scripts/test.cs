using System;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{

    public TextMeshProUGUI talkPrompt;

    bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        talkPrompt.color = new Color(255, 0, 255, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
        pressed = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && !pressed)
        {
            pressed = true;
            talkPrompt.color = new Color(0, 0, 0, 0);
            Application.OpenURL("https://shattereddisk.github.io/rickroll/rickroll.mp4");
            //initiate the rickroll

        }
    }
}
